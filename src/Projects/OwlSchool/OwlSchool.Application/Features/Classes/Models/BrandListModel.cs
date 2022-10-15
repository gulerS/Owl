
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlSchool.Application.Features.Classes.Dtos;

namespace OwlSchool.Application.Features.Classes.Models;

    public class ClassListModel:BasePageableModel
    {
        public IList<ClassListDto> Items { get; set; }

        //
    }
