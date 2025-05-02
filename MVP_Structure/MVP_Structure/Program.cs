using MVP_Structure.Presenter.MainForm;

namespace MVP_Structure
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MainForm view = new MainForm();
            IMainFormPresenter presenter = new MainFormPresenter(view);
            view.Init(presenter);
            Application.Run(view);
        }
    }
}