using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.Model
{
    public class UserViewerModel
    {
        public string UserName { get; }
        public string Email { get; }
        public string Age { get; }
        public bool IsWedding { get; }
        public UserViewerModel(string userName, string email, string age, bool isWedding)
        {
            UserName = userName;
            Email = email;
            Age = age;
            IsWedding = isWedding;
        }


    }
}
