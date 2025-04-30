using MVP_Structure.Model;

namespace MVP_Structure.Presenter.MainForm
{
    public interface IMainFormPresenter 
    {
        public void InitUserListView();
        public void InsertUser(User _user);
    }
}
