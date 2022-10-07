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
        private readonly UserStore _storeUser;

        private UserViewerModel _selectedUser;

        public SelectedUserViewerStore(UserStore storeUser)
        {
            _storeUser = storeUser;
            _storeUser.UpdateUser += _storeUser_UpdateUserChange;
        }

        private void _storeUser_UpdateUserChange(UserViewerModel obj)
        {
            if(obj.UserId == SelectedUser?.UserId)
            {
                SelectedUser = obj; 
            }
        }

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
