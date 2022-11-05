using Core.Persistence.Repositories;
using Core.Security.Entities;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Persistence.Contexts;

namespace OwlSchool.Persistence.Repositories;

    public class OperationClaimRepository : EFRepositoryBase<OperationClaim, BaseDbContext>, IOperationClaimRepository
    {
        public OperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }

