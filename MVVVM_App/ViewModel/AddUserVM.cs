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
    public class AddUserVM : ViewModelBase
    {
        public UserViewerDeatailsFormVM UserViewerDeatailsFormVM { get; }
        public AddUserVM(NavigationStore navigationStore,UserStore user)
        {
            ICommand submitCommand = new SubmitAddUserCommand(this,navigationStore,user);
            ICommand cancel = new ClosemodalCommand(navigationStore);
            UserViewerDeatailsFormVM = new UserViewerDeatailsFormVM(submitCommand, cancel);
        }
    }
}
