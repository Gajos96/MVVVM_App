using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVVM_App.Commands
{
    public abstract class CommandBased : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }
        public abstract void Execute(object? parameter);

        public virtual void OnCanExecutedChange()
        {
            CanExecuteChanged?.Invoke(this , new EventArgs());
        }
    }
}
