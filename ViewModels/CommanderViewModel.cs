using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

using Commander_v2.Commands;
using Commander_v2.Models;
using Commander_v2.Views;




namespace Commander_v2.ViewModels
{
    class CommanderViewModel
    {
        /// <summary>
        /// Initializes a new instance of the CommanderViewModel class;
        /// </summary>
        public CommanderViewModel()
        {
            _Commander = new Commander();
            SearchCommand = new CommanderSearchCommand(this);
            
        }
        private Commander _Commander;
        /// <summary>
        /// Gets the commander instance
        /// </summary>
        public Commander Commander
        {
            get { return _Commander; }
        }
        /// <summary>
        /// Gets the CloseMainWindowCommand for the ViewModel. Simply closes the main window.
        /// </summary>

        public ICommand SearchCommand
        {
            get;
            private set;
        }

        public void Search()
        {
            //Commander com = new Commander();
            //CVM.Commander.LeftDirContent[leftListView.SelectedIndex].Name

            //Commander com = new Commander();

            FindFilesWindow winSearch = new FindFilesWindow();
            winSearch.Show();
        }

    }
}



