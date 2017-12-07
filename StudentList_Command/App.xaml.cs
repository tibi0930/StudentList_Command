using System.Windows;
using StudentList_Command.View;
using StudentList_Command.ViewModel;

namespace StudentList_Command
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Startup += new StartupEventHandler(App_Startup);
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            StudentsViewModel viewModel = new StudentsViewModel();
            window.DataContext = viewModel;
            window.Show();
        }
    }
}
