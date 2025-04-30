using MVP_Structure.Model;

namespace MVP_Structure.View.MainFormView
{
    public interface IMainFormView : IView
    {
        public void AddUserToListView(User _userList);
    }
}
