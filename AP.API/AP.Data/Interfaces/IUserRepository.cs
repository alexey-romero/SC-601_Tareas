using AP.Data.Models;

namespace AP.Data.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        //public int AssignRandomFavoriteNumber (int userId);
        Task<User> GetUserAddresses(int userId);
    }
}
