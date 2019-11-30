using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchDirectoriesAndFiles
{
    public static class SearchDirectoriesAndFiles
    {
        public enum SearchFileNameOption
        {
            MatchCase,
            WholeWord,
            Normal,
            None
        }
        public static void GetDirectories(string path, ref List<string> listDir, bool containHiddenDir, bool containReadOnlyDir)
        {
            try
            {
                listDir.Add(path);
                foreach (string d in Directory.GetDirectories(path))
                {
                    SearchHiddenReadOnly(path, listDir, containHiddenDir, containReadOnlyDir);
                    GetDirectories(d, ref listDir, containHiddenDir, containReadOnlyDir);
                }
            }

            catch
            {

            }
        }

        public static void GetDirectories(string path, ref List<string> listDir)
        {
            GetDirectories(path, ref listDir, true, true);
        }
        
        public static void GetFiles(string path, ref List<string> file)
        {
            GetFiles(path, ref file, true, true, string.Empty);
        }

        public static void GetFiles(string path, ref List<string> file, string extention)
        {
            GetFiles(path, ref file, true, true, extention);
        }

        public static void GetFiles(string path, ref List<string> files, string searchFileName, SearchFileNameOption option)
        {
            List<string> getDir = new List<string>();
            GetDirectories(path, ref getDir);
            foreach (string dir in getDir)
            {
                foreach (string f in Directory.GetFiles(dir))
                {
                    FileInfo fileInfo = new FileInfo(f);
                    string mainFileName = Path.GetFileNameWithoutExtension(f);
                    if (searchFileName == string.Empty)
                        return;
                    switch (option)
                    {
                        case SearchFileNameOption.MatchCase:
                            if (mainFileName.Contains(searchFileName))
                                files.Add(f);
                            break;
                        case SearchFileNameOption.WholeWord:
                            if (mainFileName == searchFileName)
                                files.Add(f);
                            break;
                        case SearchFileNameOption.Normal:
                            if (mainFileName.ToLower() == searchFileName.ToLower())
                                files.Add(f);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static void GetFiles(string path, ref List<string> files, bool containHiddenFiles, bool containReadOnlyFiles, string extention, string searchFileName, SearchFileNameOption option)
        {
            try
            {
                List<string> getDir = new List<string>();
                GetDirectories(path, ref getDir);
                foreach (string dir in getDir)
                {
                    foreach (string f in Directory.GetFiles(dir))
                    {
                        string mainFileName = Path.GetFileNameWithoutExtension(f);
                        if (searchFileName != string.Empty)
                        {
                            switch (option)
                            {
                                case SearchFileNameOption.MatchCase:
                                    if (mainFileName.Contains(searchFileName))
                                        files.Add(f);
                                    break;
                                case SearchFileNameOption.WholeWord:
                                    if (mainFileName == searchFileName)
                                        files.Add(f);
                                    break;
                                case SearchFileNameOption.Normal:
                                    if (mainFileName.ToLower() == searchFileName.ToLower())
                                        files.Add(f);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (extention == string.Empty)
                            SearchHiddenReadOnly(f, files, containHiddenFiles, containReadOnlyFiles);
                        else
                        {
                            DirectoryInfo fileInfo = new DirectoryInfo(f);
                            if (fileInfo.Extension.Contains(extention))
                                SearchHiddenReadOnly(f, files, containHiddenFiles, containReadOnlyFiles);
                        }
                    }
                }
            }
            catch
            {
            }

        }

        private static void SearchHiddenReadOnly(string file, List<string> files, bool containHiddenFiles, bool containReadOnlyFiles)
        {
            DirectoryInfo fileInfo = new DirectoryInfo(file);
            if (containHiddenFiles == true && containReadOnlyFiles == true)
                files.Add(file);
            else if (containHiddenFiles == true && containReadOnlyFiles == false)
            {
                if ((fileInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    files.Add(file);
            }
            else if (containHiddenFiles == false && containReadOnlyFiles == true)
            {
                if ((fileInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    files.Add(file);
            }
            else if (((fileInfo.Attributes & FileAttributes.ReadOnly) != FileAttributes.ReadOnly) && ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden))
                files.Add(file);
        }
    }
}
