using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFileApplication.Classes
{
    public enum SearchFileNameOption
    {
        MatchCase,
        WholeWord,
        Normal,
        None
    }
    public static class SearchIO
    {
        public static void GetAllDirectories(string path, ref List<string> dirList)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo info = new DirectoryInfo(dir);
                    if (((info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) ||
                       ((info.Attributes & FileAttributes.System) == FileAttributes.System))
                        continue;
                  
                    dirList.Add(dir);
                    GetAllDirectories(dir, ref dirList); // Recursive Method

                }
            }
            catch
            {
            }

        }

        public static List<string> SearchFile(string path)
        {
            return SearchFile(path, string.Empty);
        }

        public static List<string> SearchFile(string path, string format)
        {
            return SearchFile(path, string.Empty, SearchFileNameOption.None, format);
        }

        public static List<string> SearchFile(string path, string searchFileName, SearchFileNameOption opt)
        {
            return SearchFile(path, searchFileName, opt, string.Empty);
        }
        public static List<string> SearchFile(string path, string searchFileName, SearchFileNameOption opt, string format)
        {
            List<string> result = new List<string>();
            List<string> allDir = new List<string>();
            GetAllDirectories(path, ref allDir);
            foreach (string dir in allDir)
            {
                foreach (string fileName in Directory.GetFiles(dir))
                {
                    bool shouldBeAdded = true;
                    FileInfo info = new FileInfo(fileName);
                    if (searchFileName != string.Empty)
                    {
                        switch (opt)
                        {
                            case SearchFileNameOption.MatchCase:
                                shouldBeAdded = Path.GetFileNameWithoutExtension(fileName).Contains(searchFileName);
                                break;
                            case SearchFileNameOption.WholeWord:
                                shouldBeAdded = Path.GetFileNameWithoutExtension(fileName) == searchFileName;
                                break;
                            case SearchFileNameOption.Normal:
                                shouldBeAdded = Path.GetFileNameWithoutExtension(fileName).ToLower().Contains(searchFileName.ToLower());
                                break;
                            default:
                                break;
                        }
                    }

                    if ((shouldBeAdded) && (format != string.Empty))
                        shouldBeAdded = info.Extension.Contains(format);
                    
                    if (shouldBeAdded)
                        result.Add(fileName);
                }
            }

            return result;
        }


    }
}
