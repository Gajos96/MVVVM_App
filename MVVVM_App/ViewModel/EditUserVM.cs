using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.ViewModel
{
    public class EditUserVM : ViewModelBase
    {
        public UserViewerDeatailsFormVM deatailsFormVM { get; }
        EditUserVM()
        {
            deatailsFormVM = new UserViewerDeatailsFormVM();
        }


    }
}
