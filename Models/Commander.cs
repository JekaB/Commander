using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace Commander_v2.Models
{
    class Commander : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the Commander class;
        /// </summary>
        /// <param name="dirPath"></param>
        public Commander()
        {
        }
        public List<String> ListOfDrives
        {
            get
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                List<string> list = new List<string>();
                foreach (var item in allDrives)
                {
                    if (item.IsReady)
                    {
                        list.Add(item.ToString());
                    }
                    

                }
                return list;
            }
        }
        private string leftDirPath = @"C:\";
        private string rightDirPath = @"D:\";
        private string text = "13";
        /// <summary>
        /// Gets or set Commander`s dirrectory Path
        /// </summary>

        public String Drive
        {
            get
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                text = "[" + allDrives[1].VolumeLabel + "]" + " " + allDrives[0].TotalFreeSpace + " of " + allDrives[0].TotalSize + " free";
                return text;
            }
            set { }
        }

        public String LeftCurrentDirPath
        {
            get { return leftDirPath; }
            set
            {
                if (leftDirPath != value)
                {
                    leftDirPath = value;
                    OnPropertyChanged("LeftDirContent");
                }
            }
        }
        public String RightCurrentDirPath
        {
            get { return rightDirPath; }
            set
            {
                if (rightDirPath != value)
                {
                    rightDirPath = value;
                    OnPropertyChanged("RightDirContent");
                }
            }
        }

        /// <summary>
        /// Gets information about directory content.
        /// </summary>

        #region rightDirContent
        List<DirsFilesPropery> RightFilesProperty
        {
            get
            {
                DirectoryInfo dir = new DirectoryInfo(RightCurrentDirPath);
                FileInfo[] fi = dir.GetFiles();
                string fullFileName;
                string fileExt;
                string fileName;
                string fileSize;
                string fileCreationTime;
                string fileAttr;
                List<DirsFilesPropery> result = new List<DirsFilesPropery>();
                foreach (var item in fi)
                {
                    fullFileName = RightCurrentDirPath + item;
                    fileExt = (Path.GetExtension(fullFileName)).Trim('.');
                    fileName = Path.GetFileNameWithoutExtension(fullFileName);
                    FileInfo file = new FileInfo(fullFileName);
                    fileSize = (file.Length).ToString();
                    fileCreationTime = (file.LastAccessTime).ToString();
                    fileAttr = (File.GetAttributes(fullFileName)).ToString();

                    DirsFilesPropery temp = new DirsFilesPropery(fileName, fileExt, fileSize, fileCreationTime, fileAttr);
                    result.Add(temp);
                }
                return result;
            }

        }


        List<DirsFilesPropery> RightDirsProperty
        {
            get
            {
                DirectoryInfo dir = new DirectoryInfo(RightCurrentDirPath);
                DirectoryInfo[] di = dir.GetDirectories();
                string fullDirName;
                string dirExt;
                string dirName;
                string dirSize;
                string dirCreationTime;
                string dirAttr;
                List<DirsFilesPropery> result = new List<DirsFilesPropery>();
                foreach (var item in di)
                {
                    fullDirName = RightCurrentDirPath + item;
                    dirExt = null;
                    dirName = new DirectoryInfo(fullDirName).Name;
                    FileInfo file = new FileInfo(fullDirName);
                    dirSize = "<DIR>";
                    dirCreationTime = (file.LastAccessTime).ToString();
                    dirAttr = (File.GetAttributes(fullDirName)).ToString();

                    DirsFilesPropery temp = new DirsFilesPropery(dirName, dirExt, dirSize, dirCreationTime, dirAttr);
                    result.Add(temp);
                }
                return result;
            }
        }

        // Довавить данные родительской папки!!!
        public List<DirsFilesPropery> RightDirContent
        {

            get
            {
                string dirName = "...";
                string dirExt = "...";
                string dirSize = "<DIR>";
                string dirCreationTime = "...";
                string dirAttr = "...";
                DirsFilesPropery temp = new DirsFilesPropery(dirName, dirExt, dirSize, dirCreationTime, dirAttr);

                List<DirsFilesPropery> result = new List<DirsFilesPropery>();

                if (RightCurrentDirPath.Length > 5)
                {
                    result.Add(temp);
                }
                

                foreach (var item in RightDirsProperty)
                    result.Add(item);
                foreach (var item in RightFilesProperty)
                    result.Add(item);


                return result;
            }
        }



        #endregion

        #region leftDirContent
        List<DirsFilesPropery> LeftFilesProperty
        {
            get
            {
                DirectoryInfo dir = new DirectoryInfo(LeftCurrentDirPath);
                FileInfo[] fi = dir.GetFiles();
                string fullFileName;
                string fileExt;
                string fileName;
                string fileSize;
                string fileCreationTime;
                string fileAttr;
                List<DirsFilesPropery> result = new List<DirsFilesPropery>();
                foreach (var item in fi)
                {
                    fullFileName = LeftCurrentDirPath + item;
                    fileExt = (Path.GetExtension(fullFileName)).Trim('.');
                    fileName = Path.GetFileNameWithoutExtension(fullFileName);
                    FileInfo file = new FileInfo(fullFileName);
                    fileSize = (file.Length).ToString();
                    fileCreationTime = (file.LastAccessTime).ToString();
                    fileAttr = (File.GetAttributes(fullFileName)).ToString();

                    DirsFilesPropery temp = new DirsFilesPropery(fileName, fileExt, fileSize, fileCreationTime, fileAttr);
                    result.Add(temp);
                }
                return result;
            }

        }


        List<DirsFilesPropery> LeftDirsProperty
        {
            get
            {
                DirectoryInfo dir = new DirectoryInfo(LeftCurrentDirPath);
                DirectoryInfo[] di = dir.GetDirectories();
                string fullDirName;
                string dirExt;
                string dirName;
                string dirSize;
                string dirCreationTime;
                string dirAttr;
                List<DirsFilesPropery> result = new List<DirsFilesPropery>();
                foreach (var item in di)
                {
                    fullDirName = LeftCurrentDirPath + item;
                    dirExt = null;
                    dirName = new DirectoryInfo(fullDirName).Name;
                    FileInfo file = new FileInfo(fullDirName);
                    dirSize = "<DIR>";
                    dirCreationTime = (file.LastAccessTime).ToString();
                    dirAttr = (File.GetAttributes(fullDirName)).ToString();

                    DirsFilesPropery temp = new DirsFilesPropery(dirName, dirExt, dirSize, dirCreationTime, dirAttr);
                    result.Add(temp);
                }
                return result;
            }
        }

        // Довавить данные родительской папки!!!
        public List<DirsFilesPropery> LeftDirContent
        {

            get
            {
                string dirName = "...";
                string dirExt = "...";
                string dirSize = "<DIR>";
                string dirCreationTime = "...";
                string dirAttr = "...";
                DirsFilesPropery temp = new DirsFilesPropery(dirName, dirExt, dirSize, dirCreationTime, dirAttr);

                List<DirsFilesPropery> result = new List<DirsFilesPropery>();

                if (LeftCurrentDirPath.Length > 5)
                {
                    result.Add(temp);
                }


                foreach (var item in LeftDirsProperty)
                    result.Add(item);
                foreach (var item in LeftFilesProperty)
                    result.Add(item);


                return result;
            }
        }



        #endregion
        
        public void Close()
        {
            this.Close();
        }


        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        public class DirsFilesPropery
        {
            public DirsFilesPropery(string fileName, string fileExt,
                string fileSize, string fileCreationTime, string fileAttr)
            {
                Name = fileName;
                Ext = fileExt;
                Size = fileSize;
                Time = fileCreationTime;
                Attr = fileAttr;
            }
            public string Name { get; set; }
            public string Ext { get; set; }
            public string Size { get; set; }
            public string Time { get; set; }
            public string Attr { get; set; }

        }

        #region INotifyPropertyChanged Members

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

