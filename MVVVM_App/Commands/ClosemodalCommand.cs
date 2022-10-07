using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.Commands
{
    public class ClosemodalCommand : CommandBased
    {

        private readonly NavigationStore navigationStore;

        public ClosemodalCommand(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            navigationStore.Close();
        }
    }
}
