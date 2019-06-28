using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    class Widgets
    {
        public static FileInfo GetFileFromDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = true,
                Title = "请选择文件",
                Filter = "所有文件(*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName != string.Empty)
                {
                    return new FileInfo(dialog.FileName);
                }
            }
            return null;
        }

        public static DirectoryInfo GetDirFromDialog()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "请选择文件路径",
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SelectedPath != string.Empty)
                {
                    return new DirectoryInfo(dialog.SelectedPath);
                }
            }
            return null;
        }
    }
}
