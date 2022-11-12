﻿using Core.Security.Entities;
using MediatR;
using OwlSchool.Application.Features.Auths.Dtos;
using OwlSchool.Application.Features.Auths.Rules;
using OwlSchool.Application.Services.AuthService;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Application.Services.UserService;

namespace OwlSchool.Application.Features.Auths.Commands.EnableOtpAuthenticator;

public class EnableOtpAuthenticatorCommand : IRequest<EnabledOtpAuthenticatorDto>
{
    public int UserId { get; set; }

    public class
        EnableOtpAuthenticatorCommandHandler : IRequestHandler<EnableOtpAuthenticatorCommand,
            EnabledOtpAuthenticatorDto>
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;
        private readonly IOtpAuthenticatorRepository _otpAuthenticatorRepository;
        private readonly AuthBusinessRules _authBusinessRules;

        public EnableOtpAuthenticatorCommandHandler(IUserService userService, IAuthService authService,
                                                    IOtpAuthenticatorRepository otpAuthenticatorRepository,
                                                    AuthBusinessRules authBusinessRules)
        {
            _userService = userService;
            _authService = authService;
            _otpAuthenticatorRepository = otpAuthenticatorRepository;
            _authBusinessRules = authBusinessRules;
        }

        public async Task<EnabledOtpAuthenticatorDto> Handle(EnableOtpAuthenticatorCommand request,
                                                             CancellationToken cancellationToken)
        {
            User user = await _userService.GetById(request.UserId);
            await _authBusinessRules.UserShouldBeExists(user);
            await _authBusinessRules.UserShouldNotBeHaveAuthenticator(user);

            OtpAuthenticator? isExistsOtpAuthenticator =
                await _otpAuthenticatorRepository.GetAsync(o => o.UserId == request.UserId);
            await _authBusinessRules.OtpAuthenticatorThatVerifiedShouldNotBeExists(isExistsOtpAuthenticator);
            if (isExistsOtpAuthenticator is not null)
                await _otpAuthenticatorRepository.DeleteAsync(isExistsOtpAuthenticator);

            OtpAuthenticator newOtpAuthenticator = await _authService.CreateOtpAuthenticator(user);
            OtpAuthenticator addedOtpAuthenticator =
                await _otpAuthenticatorRepository.AddAsync(newOtpAuthenticator);

            EnabledOtpAuthenticatorDto enabledOtpAuthenticatorDto = new()
            {
                SecretKey = await _authService.ConvertSecretKeyToString(addedOtpAuthenticator.SecretKey)
            };
            return enabledOtpAuthenticatorDto;
        }
    }
}