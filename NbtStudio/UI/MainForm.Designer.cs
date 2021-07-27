﻿namespace NbtStudio.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.NbtTree = new NbtStudio.UI.NbtTreeView();
            this.MenuAutomate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.Location = new System.Drawing.Point(0, 24);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(933, 25);
            this.Tools.TabIndex = 1;
            this.Tools.Text = "toolStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuEdit,
            this.MenuSearch,
            this.MenuAutomate,
            this.MenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(933, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "&File";
            this.MenuFile.DropDownOpening += new System.EventHandler(this.MenuFile_DropDownOpening);
            // 
            // MenuEdit
            // 
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(39, 20);
            this.MenuEdit.Text = "&Edit";
            this.MenuEdit.DropDownOpening += new System.EventHandler(this.MenuEdit_DropDownOpening);
            // 
            // MenuSearch
            // 
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(54, 20);
            this.MenuSearch.Text = "&Search";
            // 
            // MenuHelp
            // 
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "&Help";
            // 
            // NbtTree
            // 
            this.NbtTree.AllowDrop = true;
            this.NbtTree.BackColor = System.Drawing.SystemColors.Window;
            this.NbtTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NbtTree.DefaultToolTipProvider = null;
            this.NbtTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NbtTree.DragDropMarkColor = System.Drawing.Color.Black;
            this.NbtTree.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NbtTree.LineColor = System.Drawing.SystemColors.ControlDark;
            this.NbtTree.LoadOnDemand = true;
            this.NbtTree.Location = new System.Drawing.Point(0, 49);
            this.NbtTree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NbtTree.Model = null;
            this.NbtTree.Name = "NbtTree";
            this.NbtTree.RowHeight = 20;
            this.NbtTree.SelectedNode = null;
            this.NbtTree.SelectionMode = Aga.Controls.Tree.TreeSelectionMode.Multi;
            this.NbtTree.ShowNodeToolTips = true;
            this.NbtTree.Size = new System.Drawing.Size(933, 470);
            this.NbtTree.TabIndex = 3;
            this.NbtTree.Text = "NBT Tree";
            this.NbtTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.NbtTree_ItemDrag);
            this.NbtTree.NodeMouseClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.NbtTree_NodeMouseClick);
            this.NbtTree.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.NbtTree_NodeMouseDoubleClick);
            this.NbtTree.SelectionChanged += new System.EventHandler(this.NbtTree_SelectionChanged);
            this.NbtTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.NbtTree_DragDrop);
            this.NbtTree.DragOver += new System.Windows.Forms.DragEventHandler(this.NbtTree_DragOver);
            // 
            // MenuAutomate
            // 
            this.MenuAutomate.Name = "MenuAutomate";
            this.MenuAutomate.Size = new System.Drawing.Size(72, 20);
            this.MenuAutomate.Text = "&Automate";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.NbtTree);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.MenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "NBT Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private NbtTreeView NbtTree;
        private System.Windows.Forms.ToolStripMenuItem MenuAutomate;
    }
}

