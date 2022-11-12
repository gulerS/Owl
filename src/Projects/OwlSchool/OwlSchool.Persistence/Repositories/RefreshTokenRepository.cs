using Core.Persistence.Repositories;
using Core.Security.Entities;
using OwlSchool.Application.Services.Repositories;
using OwlSchool.Persistence.Contexts;

namespace Persistence.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, BaseDbContext>, IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context) : base(context)
    {
    }
}