using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string[] titles = { "文件名", "路径", "大小" };
            for (var i = 0; i < titles.Length; i++)
            {
                ColumnHeader ch = new ColumnHeader
                {
                    Text = titles[i],
                    Width = 120,
                    TextAlign = HorizontalAlignment.Left
                };
                FileListView.Columns.Add(ch);
                FileListView.BeginUpdate();
            }
            FileListView.View = View.Details;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(this, "MainForm_Load");
            ToolTip.Show("MainForm_Load", this);
            //MessageBox.Show("MainForm_Load");
        }

        private void ToolStripMenuItemFileHolder_Click(object sender, EventArgs e)
        {
            var dir = Widgets.GetDirFromDialog();
            if (dir == null)
                return;

            var files = dir.GetFiles();
            UpdateListView(files);
        }

        private void UpdateListView(FileInfo[] files)
        {
            if (files != null && files.Length > 0)
            {
                FileListView.BeginUpdate();
                FileListView.Items.Clear();
                foreach (var file in files)
                {
                    var index = FileListView.Items.Count + 1;
                    ListViewItem lvi = new ListViewItem
                    {
                        ImageIndex = index,
                        Text = file.Name
                    };
                    lvi.SubItems.Add(file.Directory.FullName);
                    lvi.SubItems.Add(Files.GetFileSizeFormat(file.Length));
                    FileListView.Items.Add(lvi);
                }
                FileListView.EndUpdate();
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FileInfo[] files = new FileInfo[fileNames.Length];

            var index = 0;
            foreach (var fileName in fileNames)
                files[index++] = new FileInfo(fileName);

            UpdateListView(files);
        }

        private void ToolStripMenuItemTest_Click(object sender, EventArgs e)
        {
            FileListView.Visible = !FileListView.Visible;
        }

        //private void OpenFileBtn_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.ShowDialog();
        //    if (dialog.FileName != string.Empty)
        //    {
        //        ScriptEngine pyEngine = Python.CreateEngine();
        //        dynamic py = pyEngine.ExecuteFile(@"charge2ascll.py");
        //        string dd = py.main(dialog.FileName);//调用脚本文件中对应的函数

        //        MessageBox.Show(dd + "\r\n");
        //    }
        //}

        //private void PyTestBtn_Click(object sender, EventArgs e)
        //{
        //    ScriptEngine pyEngine = Python.CreateEngine();
        //    dynamic py = pyEngine.ExecuteFile(@"test.py");
        //    string dd = py.main("测试");//调用脚本文件中对应的函数

        //    MessageBox.Show(dd + "\r\n");
        //}
    }
}
