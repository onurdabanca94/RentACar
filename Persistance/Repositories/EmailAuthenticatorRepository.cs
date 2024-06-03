using Application.Services.Repositories;
using Core.Persistance.Repositories;
using Core.Security.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class EmailAuthenticatorRepository : EfRepositoryBase<EmailAuthenticator, int, BaseDbContext>, IEmailAuthenticatorRepository
{
    public EmailAuthenticatorRepository(BaseDbContext context)
        : base(context)
    {

    }
}
