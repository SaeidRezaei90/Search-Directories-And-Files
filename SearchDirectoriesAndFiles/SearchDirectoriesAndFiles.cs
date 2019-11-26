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

        public static void GetDirectories(string path, ref List<string> listDir, bool containHiddenDir, bool containReadOnlyDir)
        {
            try
            {
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
        public static void GetFiles(string path, ref List<string> file, bool containHiddenFiles, bool containReadOnlyFiles, string extention)
        {
            try
            {
                List<string> getDir = new List<string>();
                GetDirectories(path, ref getDir);
                foreach (string dir in getDir)
                {
                    foreach (string f in Directory.GetFiles(dir))
                    {
                        if (extention == string.Empty)
                            SearchHiddenReadOnly(f, file, containHiddenFiles, containReadOnlyFiles);
                        else
                        {
                            DirectoryInfo fileInfo = new DirectoryInfo(f);
                            if (fileInfo.Extension.Contains(extention))
                                SearchHiddenReadOnly(f, file, containHiddenFiles, containReadOnlyFiles);

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
