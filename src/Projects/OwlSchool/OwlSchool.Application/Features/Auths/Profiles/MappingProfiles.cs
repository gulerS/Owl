using AutoMapper;
using Core.Security.Entities;
using OwlSchool.Application.Features.Auths.Dtos;

namespace OwlSchool.Application.Features.Auths.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RefreshToken, RevokedTokenDto>().ReverseMap();
    }
}