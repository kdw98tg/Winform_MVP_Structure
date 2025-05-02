using MVP_Structure.Exceptions;
using MVP_Structure.Model;
using MVP_Structure.Repository;
using MVP_Structure.Service;
using MVP_Structure.View.MainFormView;

namespace MVP_Structure.Presenter.MainForm
{
    public class MainFormPresenter : IMainFormPresenter
    {
        private IMainFormView mainView = null;

        private UserService userService = null;

        public MainFormPresenter(IMainFormView presenter)
        {
            mainView = presenter;
            userService = new UserService(new UserRepository());
        }

        public void InitUserListView()
        {
            List<User> userList = userService.GetAllUsers();

            foreach (User user in userList)
            {
                mainView.AddUserToListView(user);
            }
        }

        public void InsertUser(User _user)
        {
            try
            {
                userService.InsertUser(_user);
                mainView.AddUserToListView(_user);
            }
            catch (UserAgeException _userAgeException)
            {
                mainView.ShowMessageBox("나이 잘못됨");
            }
            catch (UserNameInvalidException _userNameException)
            {
                mainView.ShowMessageBox("이름 잘못됨" + _userNameException.Message, _userNameException.InnerException.ToString());
            }
        }
    }
}
