using MVVVM_App.Store;
using MVVVM_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.Commands
{
    public class OpenAddUserCommand : CommandBased
    {

        private readonly NavigationStore _navigationStore;
        private UserStore _userStore;

        public OpenAddUserCommand(UserStore userStore, NavigationStore navigationStore)
        {
            _userStore = userStore;
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentVM = new AddUserVM(_navigationStore,_userStore);

        }
    }
}
