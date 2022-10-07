using MVVVM_App.Commands;
using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.ViewModel
{
    public class UserListVM : ViewModelBase
    {
        public UserViewersDetailsVM UserViewersDetailsVM { get; }
        public UserViewersListVM UserViewersListVM { get;}

        public ICommand AddUserViewersCommand { get;}

        public UserListVM(SelectedUserViewerStore _selectedUserViewerStore, NavigationStore navigationStore, UserStore userStore)
        {
            UserViewersDetailsVM = new UserViewersDetailsVM(_selectedUserViewerStore);
            UserViewersListVM = new UserViewersListVM(_selectedUserViewerStore,navigationStore, userStore);
            AddUserViewersCommand = new OpenAddUserCommand(userStore, navigationStore);
        }

    }
}
