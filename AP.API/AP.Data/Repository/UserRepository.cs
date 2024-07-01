using AP.Data.Data;
using AP.Data.Models;
using AP.Data.Interfaces;

namespace AP.Data.Repository;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}