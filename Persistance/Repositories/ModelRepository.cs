using Application.Services.Repositories;
using Core.Persistance.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class ModelRepository : EfRepositoryBase<Model, Guid, BaseDbContext>, IModelRepository
{
    public ModelRepository(BaseDbContext context) : base(context)
    {
    }
}
