using Core.Persistence.Repositories;
using Core.Security.Entities;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Persistence.Contexts;

namespace Persistence.Repositories;

public class UserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, BaseDbContext>,
                                            IUserOperationClaimRepository
{
    public UserOperationClaimRepository(BaseDbContext context) : base(context)
    {
    }
}