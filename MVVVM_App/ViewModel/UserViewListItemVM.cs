using MVVVM_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.ViewModel
{
    public class UserViewListItemVM : ViewModelBase
    {
        public UserViewerModel _viewer { get; }
        /// <summary 
        /// Obsługa w kontrolce
        /// </summary>
        public string UserName => _viewer.UserName;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public UserViewListItemVM(UserViewerModel user)
        {
            _viewer = user;
        }
    }
}
