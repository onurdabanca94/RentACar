using Application.Services.Repositories;
using Core.Persistance.Repositories;
using Core.Security.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class OtpAuthenticatorRepository : EfRepositoryBase<OtpAuthenticator, int, BaseDbContext>, IOtpAuthenticatorRepository
{
    public OtpAuthenticatorRepository(BaseDbContext context)
        : base(context)
    {

    }
}
