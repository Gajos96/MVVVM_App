using MVVVM_App.Commands;
using MVVVM_App.Model;
using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.ViewModel
{
    public class EditUserVM : ViewModelBase
    {
        public Guid UserId { get; }
        public UserViewerDeatailsFormVM UserViewerDeatailsFormVM { get; }
        public EditUserVM(UserViewerModel usermodel, UserStore storeUser ,NavigationStore _navigationStore)
        {
            UserId = usermodel.UserId;
            ICommand submitCommand = new SubmitEditUserCommand(this ,storeUser, _navigationStore);
            ICommand cancelCommand = new ClosemodalCommand(_navigationStore);
            UserViewerDeatailsFormVM = new UserViewerDeatailsFormVM(submitCommand , cancelCommand)
            {
                Username = usermodel.UserName,
                Email = usermodel.Email,
                Age = usermodel.Age,
                SelectYesNo = usermodel.IsWedding
            };
        }



    }
}
