using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            for (var i = 0; i < 3; i++)
            {
                ColumnHeader ch = new ColumnHeader
                {
                    Text = "列标题" + i,
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

        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("SelectToolStripMenuItem_Click");
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ToolStripMenuItem1_Click");
        }

        private void ToolStripMenuItem1_MouseUp(object sender, MouseEventArgs e)
        {
            FileListView.BeginUpdate();  //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度 

            var index = FileListView.Items.Count + 1;
            ListViewItem lvi = new ListViewItem
            {
                ImageIndex = index,     //通过与imageList绑定，显示imageList中第i项图标 
                Text = "subitem" + index
            };
            lvi.SubItems.Add("第2列,第" + index + "行");
            lvi.SubItems.Add("第3列,第" + index + "行");
            FileListView.Items.Add(lvi);
            FileListView.EndUpdate();  //结束数据处理，UI界面一次性绘制。
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
