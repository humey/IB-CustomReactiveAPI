using CustomTrading.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomTrading.Utility
{
    public class UpdateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        // Simple execute to change the views
        // Make it cleaner and put the views in a list
        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
        }
    }
}
