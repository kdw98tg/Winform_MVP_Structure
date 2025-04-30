using MVP_Structure.Model;

namespace MVP_Structure.Repository
{
    public interface IUserRepository
    {
        public List<User> GetAllUser();
        public void InsertUser(User _newUser);
        public void DeleteUser(User _user);
    }
}
