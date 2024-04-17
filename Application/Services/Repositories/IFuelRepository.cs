using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IFuelRepository : IAsyncRepository<Fuel, Guid>, IRepository<Fuel, Guid>
{
}