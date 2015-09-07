using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Commander_v2.ViewModels;

namespace Commander_v2.Commands
{
    internal class CommanderSearchCommand : ICommand
    {
        public CommanderSearchCommand(CommanderViewModel viewModel)
        {
            _ViewModel = viewModel;
        }
        private CommanderViewModel _ViewModel;


        #region ICommand Members;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _ViewModel.Search();
        }

        #endregion
    }
}
