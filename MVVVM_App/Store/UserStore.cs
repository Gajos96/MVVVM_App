using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVVM_App.Model;

namespace MVVVM_App.Store
{
    public class UserStore
    {
       public event Action<UserViewerModel> AddUser;
       public event Action<UserViewerModel> UpdateUser;
        public async Task Add(UserViewerModel userViewerModel)
        {
            AddUser?.Invoke(userViewerModel);
        }

        public async Task Update(UserViewerModel userViewerModel)
        {
            UpdateUser?.Invoke(userViewerModel);
        }

    }
}
