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

        public IEnumerable<User> GetAllUsers()
        {
            // Business logic can be added here
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            // Business logic can be added here
            return _userRepository.GetUserById(id);
        }

        public void CreateUser(User user)
        {
            // Business logic can be added here, such as validation
            _userRepository.CreateUser(user);
        }

        public void UpdateUser(User user)
        {
            // Business logic can be added here, such as validation
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            // Business logic can be added here, such as checking dependencies
            _userRepository.DeleteUser(id);
        }
    }
}
