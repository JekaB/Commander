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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;


using System.Collections;

using Commander_v2.ViewModels;



namespace Commander_v2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CommanderViewModel();
        }

        private void ListView_MouseDoubleClick_leftListView(object sender, MouseButtonEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;

            if (CVM.Commander.LeftDirContent[leftListView.SelectedIndex].Size == "<DIR>")
            {
                CVM.Commander.LeftCurrentDirPath += CVM.Commander.LeftDirContent[leftListView.SelectedIndex].Name.ToString() + @"\";
            }
            else
            {
                string filePath = null;
                filePath = CVM.Commander.LeftCurrentDirPath;
                filePath += CVM.Commander.LeftDirContent[leftListView.SelectedIndex].Name + "." + CVM.Commander.LeftDirContent[leftListView.SelectedIndex].Ext;
                try
                {
                    Process.Start(filePath);
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
        private void ListView_MouseDoubleClick_rightListView(object sender, MouseButtonEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;

            if (CVM.Commander.RightDirContent[rightListView.SelectedIndex].Size == "<DIR>")
            {
                CVM.Commander.RightCurrentDirPath += CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name.ToString() + @"\";

            }
            else
            {
                string filePath = null;
                filePath = CVM.Commander.RightCurrentDirPath;
                filePath += CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name + "." + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Ext;
                try
                {
                    Process.Start(filePath);
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }


        private void Button_ALTF4_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region DockPanel Combobox Right
        private void cbxRight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxRight.SelectedItem != null)
            {
                var CVM = DataContext as CommanderViewModel;
                string text = (sender as ComboBox).SelectedItem.ToString();
                CVM.Commander.RightCurrentDirPath = text;

            }
            else
            {
                // MessageBox.Show("null");
            }

        }

        private void Button_rdRight_Click(object sender, RoutedEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;
            string path = CVM.Commander.RightCurrentDirPath;
            string[] spath = (path.ToString()).Split('\\');
            path = spath[0] + '\\';
            CVM.Commander.RightCurrentDirPath = path;
            //MessageBox.Show(path);
        }

        private void Button_parentRight_Click(object sender, RoutedEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;
            CVM.Commander.RightCurrentDirPath += "...\\";

        }

        #endregion

        #region DockPanel Combobox Left
        private void cbxLeft_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxRight.SelectedItem != null)
            {
                var CVM = DataContext as CommanderViewModel;
                string text = (sender as ComboBox).SelectedItem.ToString();
                CVM.Commander.LeftCurrentDirPath = text;

            }
            else
            {
                //MessageBox.Show("null");
            }

        }
        private void Button_rdLeft_Click(object sender, RoutedEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;
            string path = CVM.Commander.LeftCurrentDirPath;
            string[] spath = (path.ToString()).Split('\\');
            path = spath[0] + '\\';
            CVM.Commander.LeftCurrentDirPath = path;
            //MessageBox.Show(path);
        }
        private void Button_parentLeft_Click(object sender, RoutedEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;
            CVM.Commander.LeftCurrentDirPath += "...\\";
        }


        #endregion


        private void MenuItem_Click_Open_Right(object sender, RoutedEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;

            if (CVM.Commander.RightDirContent[rightListView.SelectedIndex].Size == "<DIR>")
            {
                string temp = CVM.Commander.RightCurrentDirPath + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name.ToString();
                Process.Start("explorer.exe", temp);

            }
            else if (CVM.Commander.RightDirContent[rightListView.SelectedIndex].Size != "<DIR>")
            {
                string filePath = null;
                filePath = CVM.Commander.RightCurrentDirPath;
                filePath += CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name + "." + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Ext;
                Process.Start(filePath);
            }
            else
            {
                string filePath = null;
                filePath = CVM.Commander.RightCurrentDirPath;
                filePath += CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name + "." + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Ext;
                Process.Start(filePath);

            }


        }

        private void MenuItem_Click_Delete_Right(object sender, RoutedEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;
            // Configure the message box to be displayed
            string temp = CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name.ToString();
            string messageBoxText = "Удалить " + temp + "?";
            string caption = "Ахтунг! Удаление!!";
            MessageBoxButton button = MessageBoxButton.OKCancel;
            MessageBoxImage icon = MessageBoxImage.Warning;

            // Display message box
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            // Process message box results
            switch (result)
            {
                case MessageBoxResult.OK:
                    // User pressed Yes button
                    // ...
                    if (CVM.Commander.RightDirContent[rightListView.SelectedIndex].Size == "<DIR>")
                    {
                        string delDirPath = CVM.Commander.RightCurrentDirPath + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name.ToString();
                        MessageBox.Show("Удаляем папку " + delDirPath);
                        //Directory.Delete(delDirPath, true);
                        string rootDir = CVM.Commander.RightCurrentDirPath;
                        //CVM.RightCurrentDirPath = rootDir;
                    }

                    else
                    {
                        string filePath = CVM.Commander.RightCurrentDirPath + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name + "." + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Ext;
                        MessageBox.Show("Удаляем файл " + filePath);
                    }

                    break;
                case MessageBoxResult.Cancel:
                    // User pressed No button
                    // ...

                    break;
            }
        }

        private void MenuItem_Click_Copy_Right(object sender, RoutedEventArgs e)
        {
            var CVM = DataContext as CommanderViewModel;


            string destPath = CVM.Commander.LeftCurrentDirPath;

            if (CVM.Commander.RightDirContent[rightListView.SelectedIndex].Size == "<DIR>")
            {
                string currDirPath = CVM.Commander.RightCurrentDirPath + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name.ToString();
                Models.Commander.DirectoryCopy(currDirPath, destPath, true);
                MessageBox.Show("Копируем папку " + currDirPath + " в " + destPath);

                string rootDir = CVM.Commander.RightCurrentDirPath;
                CVM.Commander.RightCurrentDirPath = rootDir;
                CVM.Commander.LeftCurrentDirPath = @"D:\";
                CVM.Commander.LeftCurrentDirPath = destPath;

            }

            else
            {
                string filePath = CVM.Commander.RightCurrentDirPath + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Name + "." + CVM.Commander.RightDirContent[rightListView.SelectedIndex].Ext;

                MessageBox.Show("Копируем файл " + filePath + " в " + destPath);
            }
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}


