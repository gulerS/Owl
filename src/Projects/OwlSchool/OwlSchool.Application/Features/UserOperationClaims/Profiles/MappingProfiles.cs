using AutoMapper;
using Core.Persistence.Paging;
using Core.Security.Entities;
using OwlSchool.Application.Features.UserOperationClaims.Commands.CreateUserOperationClaim;
using OwlSchool.Application.Features.UserOperationClaims.Commands.DeleteUserOperationClaim;
using OwlSchool.Application.Features.UserOperationClaims.Commands.UpdateUserOperationClaim;
using OwlSchool.Application.Features.UserOperationClaims.Dtos;
using OwlSchool.Application.Features.UserOperationClaims.Models;

namespace OwlSchool.Application.Features.UserOperationClaims.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<UserOperationClaim, CreateUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, CreatedUserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, UpdateUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, UpdatedUserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, DeleteUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, DeletedUserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, UserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, UserOperationClaimListDto>().ReverseMap();
        CreateMap<IPaginate<UserOperationClaim>, UserOperationClaimListModel>().ReverseMap();
    }
}