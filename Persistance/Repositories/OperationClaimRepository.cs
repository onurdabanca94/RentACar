using Application.Services.Repositories;
using Core.Persistance.Repositories;
using Core.Security.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class OperationClaimRepository : EfRepositoryBase<OperationClaim, int, BaseDbContext>, IOperationClaimRepository
{
    public OperationClaimRepository(BaseDbContext context)
        : base(context)
    {

    }
}
