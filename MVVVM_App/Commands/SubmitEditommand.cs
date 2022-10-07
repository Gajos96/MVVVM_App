using MVVVM_App.Model;
using MVVVM_App.Store;
using MVVVM_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.Commands
{
    public class SubmitEditUserCommand : AsyncCommandBased
    {
        private readonly NavigationStore _navigationStore;
        private readonly UserStore _userStore;
        private readonly EditUserVM _editUserVM;

        public SubmitEditUserCommand(EditUserVM edit, UserStore userStore, NavigationStore navigationStore)
        {

            _navigationStore = navigationStore;
            _userStore = userStore;
            _editUserVM = edit;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            UserViewerDeatailsFormVM abc = _editUserVM.UserViewerDeatailsFormVM;
            var user = new UserViewerModel(
                _editUserVM.UserId,
                abc.Username,
                abc.Email,
                abc.Age,
                abc.SelectYesNo);
            try
            {
                await _userStore.Update(user);
                _navigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
