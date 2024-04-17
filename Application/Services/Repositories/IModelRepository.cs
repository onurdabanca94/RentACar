using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IModelRepository : IAsyncRepository<Model, Guid>, IRepository<Model, Guid>
{
}
