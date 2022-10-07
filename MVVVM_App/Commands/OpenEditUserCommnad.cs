using MVVVM_App.Model;
using MVVVM_App.Store;
using MVVVM_App.View;
using MVVVM_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.Commands
{
    public class OpenEditUserCommnad : CommandBased
    {

        private readonly NavigationStore _navigationStore;
        private readonly UserViewListItemVM _userViewListItemVM;
        private readonly UserStore _store;

        public OpenEditUserCommnad(UserViewListItemVM userViewListItemVM, UserStore store, NavigationStore navigationStore)
        {
            _userViewListItemVM = userViewListItemVM;
            _store = store;
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            var editUserVM = _userViewListItemVM._viewer;

            EditUserVM editVM = new EditUserVM(editUserVM, _store ,_navigationStore);
            _navigationStore.CurrentVM = editVM;
        }
    }
}
