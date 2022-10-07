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
        private readonly NavigationStore _navigationStore;
        private readonly UserStore _userStore;
        public App()
        {
            _navigationStore = new NavigationStore();
            _userStore = new UserStore();   
            selectedUserViewerStore = new SelectedUserViewerStore(_userStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            UserListVM userListVM = new UserListVM
                (
                selectedUserViewerStore,
                _navigationStore,
                _userStore
                );
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore, userListVM)
            };
            MainWindow.Show();
            base.OnStartup(e);
            
        }
    }
}
