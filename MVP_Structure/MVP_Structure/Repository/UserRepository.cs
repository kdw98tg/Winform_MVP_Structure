using MVP_Structure.Model;

namespace MVP_Structure.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> userList = null;

        public UserRepository()
        {
            userList = new List<User>();
            userList.Add(new User() { UserId = 1, UserName = "홍길동", UserAge = 12 });
        }

        public List<User> GetAllUser()
        {
            return userList;
        }

        public void InsertUser(User _newUser)
        {
            userList.Add(_newUser);
        }

        public void DeleteUser(User _user)
        {
            userList.Remove(_user);
        }
    }
}
