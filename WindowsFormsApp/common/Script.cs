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
        public static void ReducePath(string root)
        {
            if (root != string.Empty)
            {
                var dir = new DirectoryInfo(root);
                Reduce(dir);
            }
        }

        private static void Reduce(DirectoryInfo dir)
        {
            var files = dir.GetFiles();
            var subDirs = dir.GetDirectories();
            if (files != null && files.Length > 0)
            {
                if (subDirs != null)
                {
                    foreach (var subDir in subDirs)
                    {
                        Reduce(subDir);
                    }
                }
            }
        }

        public void Traversal()
        {

        }
    }
}
