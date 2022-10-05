using MVVVM_App.Model;
using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MVVVM_App.ViewModel
{
    public class UserViewersDetailsVM : ViewModelBase
    {
        private readonly SelectedUserViewerStore _selectedUserViewerStore;
        private UserViewerModel _userListVM => _selectedUserViewerStore.SelectedUser;
        public bool HasSelectedUserViewer => _userListVM != null;
        public string UserName => _userListVM?.UserName ?? "Unknow";
        public string Email => _userListVM?.Email ?? "Unknow";
        public string Age => _userListVM?.Age ?? "Unknow";
        public string IsWedding => (_userListVM?.IsWedding ?? false) ? "Yes" : "No" ;

        public UserViewersDetailsVM(SelectedUserViewerStore selectedUserViewerStore)
        {
            _selectedUserViewerStore = selectedUserViewerStore;
            //Oświeża po kliknieciu baze
            _selectedUserViewerStore.SelectedUserViewerChanged += SelectedUserViewerStore_SeletedUserChange;
        }

        protected override void Dispose()
        {
            _selectedUserViewerStore.SelectedUserViewerChanged -= SelectedUserViewerStore_SeletedUserChange;
            base.Dispose();
        }

        private void SelectedUserViewerStore_SeletedUserChange()
        {
            OnPropertyChanged(nameof(HasSelectedUserViewer));
            OnPropertyChanged(nameof(UserName));
            OnPropertyChanged(nameof(Email));
            OnPropertyChanged(nameof(Age));
            OnPropertyChanged(nameof(IsWedding));
        }



    }
}
