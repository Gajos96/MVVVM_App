using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.ViewModel
{
    public class AddUserVM : ViewModelBase
    {
        public UserViewerDeatailsFormVM UserViewerDeatailsFormVM { get; }
        public AddUserVM()
        {
            UserViewerDeatailsFormVM = new UserViewerDeatailsFormVM();
        }
    }
}
