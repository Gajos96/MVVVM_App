using MVVVM_App.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public UserListVM _userListVM { get; }
        public ViewModelBase CurrentForm => _navigationStore.CurrentVM;
        public bool IsOpen => _navigationStore.IsOpen;
        public MainViewModel(NavigationStore navigation ,UserListVM userListVM)
        {
            _navigationStore = navigation;
            _navigationStore.CurrentViewChanged += NavigationStore_CurrentViewChanged;
            _userListVM = userListVM;
        }
        protected override void Dispose()
        {
            _navigationStore.CurrentViewChanged -= NavigationStore_CurrentViewChanged;
            base.Dispose();
        }
        private void NavigationStore_CurrentViewChanged()
        {
            OnPropertyChanged(nameof(CurrentForm));
            OnPropertyChanged(nameof(IsOpen));
        }
    }
}
