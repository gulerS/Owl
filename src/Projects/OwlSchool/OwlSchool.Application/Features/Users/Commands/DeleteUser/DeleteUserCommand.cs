using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using MediatR;
using OwlSchool.Application.Features.Users.Dtos;
using OwlSchool.Application.Features.Users.Rules;
using OwlSchool.Application.Services.Repositories;
using static OwlSchool.Application.Features.Users.Constants.OperationClaims;
using static OwlSchool.Domain.Constants.OperationClaims;

namespace OwlSchool.Application.Features.Users.Commands.DeleteUser;

public class DeleteUserCommand : IRequest<DeletedUserDto>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { Admin, UserDelete };

    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeletedUserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;

        public DeleteUserCommandHandler(IUserRepository userRepository, IMapper mapper,
                                        UserBusinessRules userBusinessRules)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
        }

        public async Task<DeletedUserDto> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            await _userBusinessRules.UserIdShouldExistWhenSelected(request.Id);

            User mappedUser = _mapper.Map<User>(request);
            User deletedUser = await _userRepository.DeleteAsync(mappedUser);
            DeletedUserDto deletedUserDto = _mapper.Map<DeletedUserDto>(deletedUser);
            return deletedUserDto;
        }
    }
}