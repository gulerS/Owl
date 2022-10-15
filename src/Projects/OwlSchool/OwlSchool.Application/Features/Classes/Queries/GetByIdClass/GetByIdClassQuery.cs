using AutoMapper;
using MediatR;
using OwlSchool.Application.Features.Classes.Dtos;
using OwlSchool.Application.Features.Classes.Rules;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Domain.Entities;

namespace OwlSchool.Application.Features.Classes.Queries.GetByIdClass;

public class GetByIdClassQuery : IRequest<ClassGetByIdDto>
{
    public int Id { get; set; }

    public class GetByIdClassQueryHandler : IRequestHandler<GetByIdClassQuery, ClassGetByIdDto>
    {
        private readonly IClassRepository _classRepository;
        private readonly IMapper _mapper;
        private readonly ClassBusinessRules _classBusinessRules;

        public GetByIdClassQueryHandler(IClassRepository classRepository, IMapper mapper,
            ClassBusinessRules classBusinessRules)
        {
            _classRepository = classRepository;
            _mapper = mapper;
            _classBusinessRules = classBusinessRules;
        }

        public async Task<ClassGetByIdDto> Handle(GetByIdClassQuery request, CancellationToken cancellationToken)
        {
            Class? classs = await _classRepository.GetAsync(b => b.Id == request.Id);

            _classBusinessRules.ClassShouldExistWhenRequested(classs);

            ClassGetByIdDto classGetByIdDto = _mapper.Map<ClassGetByIdDto>(classs);
            return classGetByIdDto;
        }
    }
}