using AutoMapper;
using Core.Persistence.Paging;
using OwlSchool.Application.Features.Classes.Commands.CreateClass;
using OwlSchool.Application.Features.Classes.Dtos;
using OwlSchool.Application.Features.Classes.Models;
using OwlSchool.Domain.Entities;

namespace OwlSchool.Application.Features.Classes.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Class, CreatedClassDto>().ReverseMap();
        CreateMap<Class, CreateClassCommand>().ReverseMap();
        CreateMap<IPaginate<Class>, ClassListModel>().ReverseMap();
        CreateMap<Class, ClassListDto>().ReverseMap();
        CreateMap<Class, ClassGetByIdDto>().ReverseMap();
    }
}