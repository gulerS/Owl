using Core.Persistence.Repositories;
using Core.Security.Entities;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Persistence.Contexts;

namespace OwlSchool.Persistence.Repositories;

    public class UserOperationClaimRepository : EFRepositoryBase<UserOperationClaim, BaseDbContext>, IUserOperationClaimRepository
    {
        public UserOperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }


