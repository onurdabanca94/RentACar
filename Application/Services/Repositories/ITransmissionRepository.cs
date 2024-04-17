using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ITransmissionRepository : IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
{
}
