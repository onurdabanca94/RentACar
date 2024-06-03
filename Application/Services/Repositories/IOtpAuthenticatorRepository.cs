using Core.Persistance.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories;

public interface IOtpAuthenticatorRepository : IAsyncRepository<OtpAuthenticator, int>, IRepository<OtpAuthenticator, int>
{
}
