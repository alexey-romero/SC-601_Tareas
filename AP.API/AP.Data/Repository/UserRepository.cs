using AP.Data.Data;
using AP.Data.Models;
using AP.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AP.Data.Repository;

public class UserRepository : Repository<User>, IUserRepository
{
    // TODO: add User specific methods

    private readonly Random _random = new Random();

    public UserRepository(AppDbContext context) : base(context)
    {
    }

    //virtual public int AssignRandomFavoriteNumber(int userId)
    //{
    //    var user = _dbSet.Find(userId);
    //    if (user == null)
    //    {
    //        throw new KeyNotFoundException("User not found");
    //    }

    //    user.FavoriteNumber = _random.Next(1, 99); // Generates a random number between 1 and 100
    //    _context.SaveChanges();

    //    return user.FavoriteNumber;
    //}

    public async Task<User> GetUserAddresses(int userId)
    {
        return await _dbSet.Include(u => u.Addresses)
                           .FirstOrDefaultAsync(u => u.UserId == userId);
    }
}