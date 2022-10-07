using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVVM_App.Commands
{
    public abstract class AsyncCommandBased : CommandBased
    {
        public override async void Execute(object? parameter)
        {
            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception) {}
            
        }

        public abstract Task ExecuteAsync(object? parameter);

    }
}
