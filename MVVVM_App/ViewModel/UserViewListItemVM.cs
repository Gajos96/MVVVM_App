using MVVVM_App.Commands;
using MVVVM_App.Model;
using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MVVVM_App.ViewModel
{
    public class UserViewListItemVM : ViewModelBase
    {
        public UserViewerModel _viewer { get; private set; }
        /// <summary 
        /// Obsługa w kontrolce
        /// </summary>
        public string UserName => _viewer.UserName;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public UserViewListItemVM(UserViewerModel user ,UserStore store, NavigationStore navigationStore)
        {
            _viewer = user;
            EditCommand = new OpenEditUserCommnad(this, store, navigationStore);
        }

        public void Update(UserViewerModel user)
        {
            _viewer = user;
            OnPropertyChanged(nameof(UserName));
        }
    }
}
