using Core.Persistence.Repositories;
using Core.Security.Entities;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Persistence.Contexts;

namespace OwlSchool.Persistence.Repositories;

    public class UserRepository : EFRepositoryBase<User, BaseDbContext>, IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {
        }
    }


