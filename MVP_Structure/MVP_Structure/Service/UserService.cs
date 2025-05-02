using MVP_Structure.Exceptions;
using MVP_Structure.Model;
using MVP_Structure.Repository;

namespace MVP_Structure.Service
{
    public class UserService
    {
        private IUserRepository userRepository = null;

        public UserService(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUser();
        }

        public void InsertUser(User _newUser)
        {
            ValidateUser(_newUser);

            userRepository.InsertUser(_newUser);
        }

        public void ValidateUser(User _newUser)
        {
            if (_newUser.UserAge <= 0)
            {
                throw new UserAgeException("나이는 음수일 수 없음");
            }
            if (string.IsNullOrEmpty(_newUser.UserName))
            {
                throw new UserNameInvalidException("이름을 넣어주세요.");
            }
        }

        public void DeleteUser(User _user)
        {
            userRepository.DeleteUser(_user);
        }
    }
}
