using Core.Persistence.Repositories;
using OwlSchool.Domain.Entities;

namespace OwlSchool.Application.Services.Repositories;

public interface IClassRepository: IAsyncRepository<Class>, IRepository<Class>
{

}