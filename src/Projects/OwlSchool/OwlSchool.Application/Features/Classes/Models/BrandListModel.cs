
using Core.Persistence.Paging;
using OwlSchool.Application.Features.Classes.Dtos;

namespace OwlSchool.Application.Features.Classes.Models;

    public class ClassListModel:BasePageableModel
    {
        public IList<ClassListDto> Items { get; set; }

        //
    }
