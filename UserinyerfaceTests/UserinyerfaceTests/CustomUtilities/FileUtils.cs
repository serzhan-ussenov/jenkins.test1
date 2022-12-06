using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace UserinyerfaceTests.CustomUtilities
{
    public static class FileUtils
    {
        public static string GetFullPath(string subFolder1, string subFolder2, string subFolder3, string fileName)
        {
            var directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (directoryName == null)
            {
                throw new Exception("Couldn't get assembly directory");
            }            
            return Path.Combine(directoryName, subFolder1, subFolder2, subFolder3, fileName);
        }

        public static string GetFullPath(string subFolder1, string subFolder2, string subFolder3, string subFolder4, string fileName)
        {
            var directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (directoryName == null)
            {
                throw new Exception("Couldn't get assembly directory");
            }
            return Path.Combine(directoryName, subFolder1, subFolder2, subFolder3, subFolder4, fileName);
        }

        public static string GetFullPath(params string[] paths)
        {
            var directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (directoryName == null)
            {
                throw new Exception("Couldn't get assembly directory");
            }
            List<string> pathsList = new List<string>(paths.ToList());
            pathsList.Insert(0, directoryName);
            paths = pathsList.ToArray();
            return Path.Combine(paths);
        }
    }
}
