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
            // Business logic can be added here
            return await _userRepository.GetAllObjectsAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            // Business logic can be added here
            return await _userRepository.GetObjectByIdAsync(id);
        }

        public async Task CreateUser(User user)
        {
            // Business logic can be added here, such as validation
            await _userRepository.CreateObjectAsync(user);
        }

        public async Task UpdateUser(User user)
        {
            // Business logic can be added here, such as validation
            await _userRepository.UpdateObjectAsync(user);
        }

        public async Task DeleteUser(int id)
        {
            // Business logic can be added here, such as checking dependencies
            await _userRepository.DeleteObjectAsync(id);
        }
    }
}
