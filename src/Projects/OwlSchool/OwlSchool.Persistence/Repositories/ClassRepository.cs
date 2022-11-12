using Core.Persistence.Repositories;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Domain.Entities;
using OwlSchool.Persistence.Contexts;

namespace OwlSchool.Persistence.Repositories;

public class ClassRepository: EfRepositoryBase<Class, BaseDbContext>, IClassRepository
{
    public ClassRepository(BaseDbContext context) : base(context)
    {
    }
        
}