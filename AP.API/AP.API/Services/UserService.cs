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
            return await _userRepository.GetAllObjects();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetObjectById(id);
        }

        public async Task CreateUser(User user)
        {
            await _userRepository.CreateObject(user);
        }

        public async Task UpdateUser(User user)
        {
            await _userRepository.UpdateObject(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteObject(id);
        }
    }
}
