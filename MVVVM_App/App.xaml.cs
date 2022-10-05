using MVVVM_App.Store;
using MVVVM_App.ViewModel;
using System.Windows;

namespace MVVVM_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedUserViewerStore selectedUserViewerStore;

        public App()
        {
            selectedUserViewerStore = new SelectedUserViewerStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new UserListVM(selectedUserViewerStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
            
        }
    }
}
