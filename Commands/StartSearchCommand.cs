using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Commander_v2.ViewModels;

namespace Commander_v2.Commands
{
    internal class StartSearchCommand: ICommand
    {
        /// <summary>
        /// Initialized a new instance of the StarSearchCommand class.
        /// </summary>
        public StartSearchCommand(SearchViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        private SearchViewModel _ViewModel;


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }
        public bool CanExecute(object parameter)
        {
            return _ViewModel.CanSearch;
        }      

        public void Execute(object parameter)
        {
            _ViewModel.StartSearch();
        }
    }

}

