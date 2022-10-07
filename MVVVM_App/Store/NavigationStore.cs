using MVVVM_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.Store
{
    public class NavigationStore
    {
        private ViewModelBase _currentVM;
        public ViewModelBase CurrentVM
        {
            get { return _currentVM; }
            set 
            {
                _currentVM = value;
                CurrentViewChanged?.Invoke();
            }
        }

        //Checks if it is open
        public bool IsOpen => CurrentVM != null;
        public event Action CurrentViewChanged;

        public void Close()
        {
            CurrentVM = null;
        }

    }
}
