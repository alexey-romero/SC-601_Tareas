using AP.Data.Interfaces;
using AP.Data.Models;
using AP.Data.Repository;
using AP.API.Interfaces;

namespace AP.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _userRepository.GetAllObjectsAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetObjectByIdAsync(id);
        }

        public async Task CreateUser(User user)
        {
            await _userRepository.CreateObjectAsync(user);
        }

        public async Task UpdateUser(User user)
        {
            await _userRepository.UpdateObjectAsync(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteObjectAsync(id);
        }

        public async Task<User> GetUserAddresses(int userId)
        {
            return await _userRepository.GetUserAddresses(userId);
        }
    }
}
