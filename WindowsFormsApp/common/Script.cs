using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Scripts
    {
        public static void Reduce(DirectoryInfo rootDir)
        {
            var files = rootDir.GetFiles();
            var dirs = rootDir.GetDirectories();

            if (dirs == null || dirs.Length == 0)
                return;

            if (files != null && files.Length > 0 || dirs.Length > 1)
            {
                foreach (var dir in dirs)
                    Reduce(dir);
            }
            else
            {
                var singleDir = dirs[0];
                while (NameEquals(rootDir, singleDir))
                {
                    var subFiles = singleDir.GetFiles();
                    var subDirs = singleDir.GetDirectories();
                    if ((subFiles == null || subFiles.Length == 0) && subDirs != null && subDirs.Length == 1)
                    {
                        singleDir = subDirs[0];
                        continue;
                    }
                    Move(rootDir, singleDir);
                    singleDir = rootDir;
                    break;
                }
                Reduce(singleDir);
            }
        }

        /// <summary>
        /// 将 subDir 里的文件剪切至 rootDir 并删除 subDir
        /// </summary>
        /// <param name="rootDir"></param>
        /// <param name="subDir"></param>
        private static void Move(DirectoryInfo rootDir, DirectoryInfo subDir)
        {
            Directory.Move(subDir.FullName, rootDir.FullName);
        }

        private static bool NameEquals(DirectoryInfo rootDir, DirectoryInfo subDir)
        {
            return rootDir.Name.Equals(subDir.Name);
        }

        public void Traversal()
        {

        }
    }
}
