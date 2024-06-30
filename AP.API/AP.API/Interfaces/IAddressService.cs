using AP.Data.Models;

namespace AP.API.Interfaces
{
    public interface IAddressService
    {
        Task<IEnumerable<User>> GetAllAddresses();
        Task<User> GetAddressById(int id);
        Task CreateAddress(User user);
        Task UpdateAddress(User user);
        Task DeleteAddress(int id);
    }
}
