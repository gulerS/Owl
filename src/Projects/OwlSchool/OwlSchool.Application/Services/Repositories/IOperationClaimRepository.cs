using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace OwlSchool.Application.Services.Repositories;

    public interface IOperationClaimRepository : IAsyncRepository<OperationClaim>, IRepository<OperationClaim>
    {
    }
