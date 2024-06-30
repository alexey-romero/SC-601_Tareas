using AP.Data.Data;
using AP.Data.Models;
using AP.Data.Interfaces;

namespace AP.Data.Repository;

public class UserRepository : Repository<User>, IUserRepository
{
    // TODO: add User specific methods
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
