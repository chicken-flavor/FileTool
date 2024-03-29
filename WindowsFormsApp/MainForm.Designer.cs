﻿using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileListView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFileHolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // FileListView
            // 
            this.FileListView.Location = new System.Drawing.Point(12, 28);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(457, 341);
            this.FileListView.TabIndex = 0;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 25);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(481, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSelect});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(481, 25);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // ToolStripMenuItemSelect
            // 
            this.ToolStripMenuItemSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFileHolder,
            this.ToolStripMenuItemTest});
            this.ToolStripMenuItemSelect.Name = "ToolStripMenuItemSelect";
            this.ToolStripMenuItemSelect.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItemSelect.Text = "选择";
            // 
            // ToolStripMenuItemFileHolder
            // 
            this.ToolStripMenuItemFileHolder.Name = "ToolStripMenuItemFileHolder";
            this.ToolStripMenuItemFileHolder.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemFileHolder.Text = "文件夹";
            this.ToolStripMenuItemFileHolder.Click += new System.EventHandler(this.ToolStripMenuItemFileHolder_Click);
            // 
            // ToolStripMenuItemTest
            // 
            this.ToolStripMenuItemTest.Name = "ToolStripMenuItemTest";
            this.ToolStripMenuItemTest.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemTest.Text = "测试";
            this.ToolStripMenuItemTest.Click += new System.EventHandler(this.ToolStripMenuItemTest_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 381);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ayyj";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView FileListView;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem ToolStripMenuItemSelect;
        private ToolStripMenuItem ToolStripMenuItemFileHolder;
        private ToolStripMenuItem ToolStripMenuItemTest;
        private ToolTip ToolTip;
    }
}

