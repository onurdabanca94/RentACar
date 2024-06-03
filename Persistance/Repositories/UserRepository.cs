using Application.Services.Repositories;
using Core.Persistance.Repositories;
using Core.Security.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class UserRepository : EfRepositoryBase<User, int, BaseDbContext>, IUserRepository
{
    public UserRepository(BaseDbContext context)
        : base(context)
    {

    }
}
