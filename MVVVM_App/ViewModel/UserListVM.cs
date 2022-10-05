using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.ViewModel
{
    internal class UserListVM : ViewModelBase
    {
        public UserViewersDetailsVM UserViewersDetailsVM { get; }
        public UserViewersListVM UserViewersListVM { get;}

        public ICommand AddUserViewersCommand { get;}

       public UserListVM(SelectedUserViewerStore _selectedUserViewerStore)
        {
            UserViewersDetailsVM = new UserViewersDetailsVM(_selectedUserViewerStore);
            UserViewersListVM = new UserViewersListVM(_selectedUserViewerStore);
        }

    }
}
