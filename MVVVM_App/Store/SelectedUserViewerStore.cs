using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVVM_App.Model;

namespace MVVVM_App.Store
{
    public class SelectedUserViewerStore
    {
        private UserViewerModel _selectedUser;
        public UserViewerModel SelectedUser
        {
            get { return _selectedUser; }
            set 
            {
                //Event bierze pod uwage jakokolweik zmiane
                _selectedUser = value;
                //Po wywołaniu OnProportychange pamietaj
                SelectedUserViewerChanged?.Invoke();
            }

        }

        public event Action SelectedUserViewerChanged;
    }
}
