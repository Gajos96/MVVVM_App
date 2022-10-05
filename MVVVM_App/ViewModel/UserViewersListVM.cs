using MVVVM_App.Model;
using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.ViewModel
{
    public class UserViewersListVM : ViewModelBase
    {

        //Hermetyzacja = 'Usuń notatkę'
        private readonly SelectedUserViewerStore _selectedUserViewerStore;

        private readonly ObservableCollection<UserViewListItemVM> _userViewListItemVMs;
        public IEnumerable<UserViewListItemVM> UserViewListItemVMs => _userViewListItemVMs;

        private UserViewListItemVM _selectedUserViewerListItemVM;
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

        public UserViewersListVM(SelectedUserViewerStore selectedUserViewerStore)
        {
            _selectedUserViewerStore = selectedUserViewerStore;
            _userViewListItemVMs = new ObservableCollection<UserViewListItemVM>();
            _userViewListItemVMs.Add(new UserViewListItemVM(new UserViewerModel("Kamil","Robaczek@wp.pl","12", true)));
            _userViewListItemVMs.Add(new UserViewListItemVM(new UserViewerModel("Seat", "Robaczek2@wp.pl", "69", true)));
            _userViewListItemVMs.Add(new UserViewListItemVM(new UserViewerModel("Misia", "Robaczek1@wp.pl", "15", false)));
        }

    }
}
