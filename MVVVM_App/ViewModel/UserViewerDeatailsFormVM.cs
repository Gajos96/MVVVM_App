using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.ViewModel
{
    public class UserViewerDeatailsFormVM : ViewModelBase
    {

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public bool CanSubmit => !string.IsNullOrEmpty(Username);

        private string _username;
        public string Username
        {
            get 
            { 
                return _username; 
            }
            set 
            {
            _username = value;
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(CanSubmit));
            }
        }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _age;
        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        private bool _selectYesNo;
        public string SelectYesNo
        {
            get
            {
                if (_selectYesNo == true) return "Yes";
                else return "No";   
            }
            set
            {
                if (value == "Yes") _selectYesNo = true; else _selectYesNo = false;
                OnPropertyChanged(nameof(SelectYesNo));
            }
        }



    }
}
