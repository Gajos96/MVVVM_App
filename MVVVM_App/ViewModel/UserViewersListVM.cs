using MVVVM_App.Commands;
using MVVVM_App.Model;
using MVVVM_App.Store;
using MVVVM_App.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.ViewModel
{
    public class UserViewersListVM : ViewModelBase
    {

        //Hermetyzacja = 'Usuń notatkę'
        private readonly UserStore store;
        private readonly SelectedUserViewerStore _selectedUserViewerStore;

        private readonly ObservableCollection<UserViewListItemVM> _userViewListItemVMs;
        public IEnumerable<UserViewListItemVM> UserViewListItemVMs => _userViewListItemVMs;

        private UserViewListItemVM _selectedUserViewerListItemVM;
        private UserStore userStore;

        public UserViewListItemVM SelectedUserViewerListItemVM
        {
            get { return _selectedUserViewerListItemVM; }
            set 
            { 
                _selectedUserViewerListItemVM = value;
                OnPropertyChanged(nameof(SelectedUserViewerListItemVM));
                _selectedUserViewerStore.SelectedUser = _selectedUserViewerListItemVM?._viewer;
            }
        }

        public NavigationStore Navigation { get; }

        public UserViewersListVM(SelectedUserViewerStore selectedUserViewerStore, NavigationStore _navigation, UserStore userStore)
        {
            store = userStore;
            _selectedUserViewerStore = selectedUserViewerStore;
            Navigation = _navigation;
            _userViewListItemVMs = new ObservableCollection<UserViewListItemVM>();

            store.AddUser += Store_AddUserChange;
            store.UpdateUser += Store_UpdateUser;

            //AddUserViewer(new UserViewerModel("Kamil", "Robaczek@wp.pl", "26", true), _navigation);
            //AddUserViewer(new UserViewerModel("Sean", "Robaczek1@wp.pl", "61", true), _navigation);
            //AddUserViewer(new UserViewerModel("Marcelinka", "Ciało@gmail.com", "12", false), _navigation);
        }

        private void Store_UpdateUser(UserViewerModel obj)
        {
            var userViewListItemVM = _userViewListItemVMs.FirstOrDefault(y => y._viewer.UserId == obj.UserId );
            if (userViewListItemVM != null)
            {
                userViewListItemVM.Update(obj);
            }
        }

        protected override void Dispose()
        {
            store.AddUser -= Store_AddUserChange;
            store.UpdateUser -= Store_UpdateUser;
            base.Dispose();
        }

        public void Store_AddUserChange(UserViewerModel user)
        {
            AddUserViewer(user);
            OnPropertyChanged(nameof(AddUserViewer));
        }
        private void AddUserViewer(UserViewerModel userViewerModel)
        {
            var itemVM = new UserViewListItemVM(userViewerModel, store, Navigation);
            _userViewListItemVMs.Add(itemVM);
        }

    }
}
