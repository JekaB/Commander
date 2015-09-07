using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using Commander_v2.Views;
using System.Windows;

namespace Commander_v2.Models
{
    class SearchModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of SearchModel class;
        /// </summary>
        public SearchModel()
        {
            
        }
        public SearchModel(string parameter)
        {
            CurrPath = parameter;
            SearchName = "13";
        }
        private string _CurrPath;
        /// <summary>
        /// Gets or sets SearchModels`s currPath.
        /// </summary>
        public String CurrPath
        {
            get { return _CurrPath; }
            set
            {
                _CurrPath = value;
                OnPropertyChanged("CurrPath");
                OnPropertyChanged("filesFound");
            }
        }

        private string _SearchName;
        /// <summary>
        /// Gets or sets SearchModels`s searchName.
        /// </summary>
        public String SearchName
        {
            get
            { return _SearchName; }

            set
            {
                _SearchName = value;
                OnPropertyChanged("SearchName");
                OnPropertyChanged("filesFound");
            }
        }

        private List<String> filesFound;
        public List<string> FilesFound
        {
            get { return filesFound; }
            set
            {
                filesFound = value;
                OnPropertyChanged("filesFound");
            }
        }




        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
