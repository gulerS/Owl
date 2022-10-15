using AutoMapper;
using MediatR;
using OwlSchool.Application.Features.Classes.Dtos;
using OwlSchool.Application.Features.Classes.Rules;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Domain.Entities;

namespace OwlSchool.Application.Features.Classes.Commands.CreateClass;

public class  CreateClassCommand:IRequest<CreatedClassDto>
{
    public string Name { get; set; }
    public int Floor { get; set; }

    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, CreatedClassDto>
    {
        private readonly IClassRepository _classRepository;
        private readonly IMapper _mapper;
        private readonly ClassBusinessRules _classBusinessRules;

        public CreateClassCommandHandler(IClassRepository classRepository, IMapper mapper, ClassBusinessRules classBusinessRules)
        {
            _classRepository = classRepository;
            _mapper = mapper;
            _classBusinessRules = classBusinessRules;
        }

        public async Task<CreatedClassDto> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            await _classBusinessRules.ClassNameCanNotBeDuplicatedWhenInserted(request.Name);

            Class mappedClass = _mapper.Map<Class>(request);
            Class createdClass = await _classRepository.AddAsync(mappedClass);
            CreatedClassDto createdClassDto = _mapper.Map<CreatedClassDto>(createdClass);

            return createdClassDto;

        }
    }
}