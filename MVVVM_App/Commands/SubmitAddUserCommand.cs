using MVVVM_App.Model;
using MVVVM_App.Store;
using MVVVM_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace MVVVM_App.Commands
{
    public class SubmitAddUserCommand : AsyncCommandBased
    {
        private readonly NavigationStore _navigationStore;

        public AddUserVM _addUserVM { get; }
        public UserStore UserStore { get; }
        public SubmitAddUserCommand(AddUserVM addUserVM ,NavigationStore navigationStore,UserStore userStore)
        {
            _addUserVM = addUserVM;
            _navigationStore = navigationStore;
            UserStore = userStore;
        }
        public override async Task ExecuteAsync(object? parameter)
        {
            var abc = _addUserVM.UserViewerDeatailsFormVM;
            var user = new UserViewerModel(
                Guid.NewGuid(),
                abc.Username,
                abc.Email,
                abc.Age,
                abc.SelectYesNo);
            try
            {
                await UserStore.Add(user);
                _navigationStore.Close();
            }
            catch (Exception)
            {

                throw;
            }

           
            
        }
    }
}
