using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using MediatR;
using OwlSchool.Application.Features.Classes.Models;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Domain.Entities;

namespace OwlSchool.Application.Features.Classes.Queries.GetListClass;

public class GetListClassQuery : IRequest<ClassListModel>
{
    public PageRequest PageRequest { get; set; }

    public class GetListClassQueryHandler : IRequestHandler<GetListClassQuery, ClassListModel>
    {
        private readonly IClassRepository _classRepository;
        private readonly IMapper _mapper;

        public GetListClassQueryHandler(IClassRepository classRepository, IMapper mapper)
        {
            _classRepository = classRepository;
            _mapper = mapper;
        }

        public async Task<ClassListModel> Handle(GetListClassQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Class> classs = await _classRepository.GetListAsync(index: request.PageRequest.Page,
                size: request.PageRequest.PageSize);

            ClassListModel mappedClassListModel = _mapper.Map<ClassListModel>(classs);

            return mappedClassListModel;
        }
    }
}