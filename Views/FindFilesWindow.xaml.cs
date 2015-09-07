using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Commander_v2.ViewModels;

namespace Commander_v2.Views
{
    /// <summary>
    /// Interaction logic for FindFilesWindow.xaml
    /// </summary>
    public partial class FindFilesWindow : Window
    {
        private string parametr;
        public String Parametr { get; set; }
        public FindFilesWindow()
        {
            InitializeComponent();
            DataContext = new SearchViewModel();
        }
        public FindFilesWindow(String parametr)
            : this()
        {
            this.parametr = parametr;
        }

        private void FFWindow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
