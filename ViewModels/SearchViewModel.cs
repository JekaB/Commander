using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.IO;

using Commander_v2.Models;
using Commander_v2.Commands;

namespace Commander_v2.ViewModels
{
    internal class SearchViewModel
    {
        /// <summary>
        /// Initializes a new instance of the SearchViewModel class.
        /// </summary>
        public SearchViewModel()
        {

            _SearchModel = new SearchModel(@"E:\Wallpapers\");
            SearchCommand = new StartSearchCommand(this);
            OpenFileCommand = new OpenSearchFileCommand(this);
        }
        /// <summary>
        /// Gets or sets a System.bool value whether the SearchModel can search.
        /// </summary>
        public bool CanSearch
        {
            get { return true; }
        }

        public bool CanOpen
        {
            get { return true; }
        }


        private SearchModel _SearchModel;
        /// <summary>
        /// Gets the SearchModel instance
        /// </summary>
        public SearchModel SearchModel
        {
            get
            {
                return _SearchModel;
            }
        }

        /// <summary>
        /// Get the StartSearchCommand for the ViewModel.
        /// </summary>
        public ICommand SearchCommand
        {
            get;
            private set;
        }


        /// <summary>
        /// Get the OpenFileCommand for the ViewModel.
        /// </summary>
        public ICommand OpenFileCommand
        {
            get;
            private set;
        }

        public void StartSearch()
        {
            //SearchModel.SearchName = "3";
            string sPath = SearchModel.CurrPath;
            string fPath = SearchModel.SearchName;
            string[] dirs = Directory.GetFiles(sPath, string.Format("*{0}*.*", fPath), SearchOption.AllDirectories);
            List<string> ff = new List<string>();

            foreach (var item in dirs)
            {
                ff.Add(item);
            }

            SearchModel.FilesFound = ff;

        }

        public void OpenFile()
        {
            
            MessageBox.Show("Выбранный файл запущен!");
        }
    }
}
