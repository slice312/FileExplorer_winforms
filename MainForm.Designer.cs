namespace FileExplorer
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
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderMainTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMainTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMainTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMainTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenFilesTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTreeCountTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.upArrowBtn = new System.Windows.Forms.ToolStripButton();
            this.addressInput = new System.Windows.Forms.ToolStripComboBox();
            this.searchInput = new System.Windows.Forms.ToolStripComboBox();
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFolderContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContexMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.listIcons = new System.Windows.Forms.ImageList(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarFileNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileEntryCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.nameColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastModifiedColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTsmi,
            this.viewTsmi,
            this.fileTreeCountTsmi});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(984, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileTsmi
            // 
            this.fileTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderMainTsmi,
            this.newFileMainTsmi,
            this.pasteMainTsmi});
            this.fileTsmi.Name = "fileTsmi";
            this.fileTsmi.Size = new System.Drawing.Size(47, 20);
            this.fileTsmi.Text = "File";
            // 
            // newFolderMainTsmi
            // 
            this.newFolderMainTsmi.Name = "newFolderMainTsmi";
            this.newFolderMainTsmi.Size = new System.Drawing.Size(180, 22);
            this.newFolderMainTsmi.Text = "New folder";
            this.newFolderMainTsmi.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // newFileMainTsmi
            // 
            this.newFileMainTsmi.Name = "newFileMainTsmi";
            this.newFileMainTsmi.Size = new System.Drawing.Size(180, 22);
            this.newFileMainTsmi.Text = "New file";
            this.newFileMainTsmi.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // pasteMainTsmi
            // 
            this.pasteMainTsmi.Name = "pasteMainTsmi";
            this.pasteMainTsmi.Size = new System.Drawing.Size(180, 22);
            this.pasteMainTsmi.Text = "Paste";
            this.pasteMainTsmi.Click += new System.EventHandler(this.Paste_Click);
            // 
            // viewTsmi
            // 
            this.viewTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMainTsmi,
            this.hiddenFilesTsmi});
            this.viewTsmi.Name = "viewTsmi";
            this.viewTsmi.Size = new System.Drawing.Size(47, 20);
            this.viewTsmi.Text = "View";
            // 
            // refreshMainTsmi
            // 
            this.refreshMainTsmi.Name = "refreshMainTsmi";
            this.refreshMainTsmi.Size = new System.Drawing.Size(180, 22);
            this.refreshMainTsmi.Text = "Refresh";
            this.refreshMainTsmi.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // hiddenFilesTsmi
            // 
            this.hiddenFilesTsmi.CheckOnClick = true;
            this.hiddenFilesTsmi.Name = "hiddenFilesTsmi";
            this.hiddenFilesTsmi.Size = new System.Drawing.Size(180, 22);
            this.hiddenFilesTsmi.Text = "Hidden files";
            this.hiddenFilesTsmi.CheckStateChanged += new System.EventHandler(this.HiddenFilesTsmi_CheckStateChanged);
            // 
            // fileTreeCountTsmi
            // 
            this.fileTreeCountTsmi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileTreeCountTsmi.Name = "fileTreeCountTsmi";
            this.fileTreeCountTsmi.Size = new System.Drawing.Size(117, 20);
            this.fileTreeCountTsmi.Text = "FileTree.Count";
            this.fileTreeCountTsmi.Click += new System.EventHandler(this.FileTreeCountTsmi_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upArrowBtn,
            this.addressInput,
            this.searchInput});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(984, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // upArrowBtn
            // 
            this.upArrowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upArrowBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upArrowBtn.Image = global::FileExplorer.Resource.up_arrow;
            this.upArrowBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.upArrowBtn.Name = "upArrowBtn";
            this.upArrowBtn.Size = new System.Drawing.Size(23, 22);
            this.upArrowBtn.Click += new System.EventHandler(this.UpArrowBtn_Click);
            // 
            // addressInput
            // 
            this.addressInput.AutoSize = false;
            this.addressInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addressInput.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressInput.ForeColor = System.Drawing.Color.Black;
            this.addressInput.Name = "addressInput";
            this.addressInput.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.addressInput.Size = new System.Drawing.Size(700, 25);
            this.addressInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressInput_KeyDown);
            // 
            // searchInput
            // 
            this.searchInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchInput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(160, 25);
            this.searchInput.Text = "Search...";
            this.searchInput.Enter += new System.EventHandler(this.SearchInput_Enter);
            this.searchInput.Leave += new System.EventHandler(this.SearchInput_Leave);
            this.searchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInput_KeyDown);
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderContextMenu,
            this.newFileContextMenu,
            this.copyTsmi,
            this.pasteContexMenu,
            this.cutTsmi,
            this.deleteTsmi,
            this.renameTsmi,
            this.refreshContextMenu,
            this.propertiesTsmi});
            this.mainContextMenuStrip.Name = "contextMenuStrip1";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(133, 202);
            this.mainContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MainContextMenuStrip_Opening);
            // 
            // newFolderContextMenu
            // 
            this.newFolderContextMenu.Name = "newFolderContextMenu";
            this.newFolderContextMenu.Size = new System.Drawing.Size(180, 22);
            this.newFolderContextMenu.Text = "New folder";
            this.newFolderContextMenu.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // newFileContextMenu
            // 
            this.newFileContextMenu.Name = "newFileContextMenu";
            this.newFileContextMenu.Size = new System.Drawing.Size(180, 22);
            this.newFileContextMenu.Text = "New file";
            this.newFileContextMenu.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // copyTsmi
            // 
            this.copyTsmi.Name = "copyTsmi";
            this.copyTsmi.Size = new System.Drawing.Size(180, 22);
            this.copyTsmi.Text = "Copy";
            this.copyTsmi.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteContexMenu
            // 
            this.pasteContexMenu.Name = "pasteContexMenu";
            this.pasteContexMenu.Size = new System.Drawing.Size(180, 22);
            this.pasteContexMenu.Text = "Paste";
            this.pasteContexMenu.Click += new System.EventHandler(this.Paste_Click);
            // 
            // cutTsmi
            // 
            this.cutTsmi.Name = "cutTsmi";
            this.cutTsmi.Size = new System.Drawing.Size(180, 22);
            this.cutTsmi.Text = "Cut";
            this.cutTsmi.Click += new System.EventHandler(this.Cut_Click);
            // 
            // deleteTsmi
            // 
            this.deleteTsmi.Name = "deleteTsmi";
            this.deleteTsmi.Size = new System.Drawing.Size(180, 22);
            this.deleteTsmi.Text = "Delete";
            this.deleteTsmi.Click += new System.EventHandler(this.Delete_Click);
            // 
            // renameTsmi
            // 
            this.renameTsmi.Name = "renameTsmi";
            this.renameTsmi.Size = new System.Drawing.Size(180, 22);
            this.renameTsmi.Text = "Rename";
            this.renameTsmi.Click += new System.EventHandler(this.Rename_Click);
            // 
            // refreshContextMenu
            // 
            this.refreshContextMenu.Name = "refreshContextMenu";
            this.refreshContextMenu.Size = new System.Drawing.Size(180, 22);
            this.refreshContextMenu.Text = "Refresh";
            this.refreshContextMenu.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // propertiesTsmi
            // 
            this.propertiesTsmi.Name = "propertiesTsmi";
            this.propertiesTsmi.Size = new System.Drawing.Size(180, 22);
            this.propertiesTsmi.Text = "Properties";
            this.propertiesTsmi.Click += new System.EventHandler(this.Properties_Click);
            // 
            // listIcons
            // 
            this.listIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.listIcons.ImageSize = new System.Drawing.Size(20, 20);
            this.listIcons.TransparentColor = System.Drawing.SystemColors.Control;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarFileNum,
            this.fileEntryCountLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 499);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(984, 22);
            this.statusBar.TabIndex = 2;
            // 
            // statusBarFileNum
            // 
            this.statusBarFileNum.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBarFileNum.Name = "statusBarFileNum";
            this.statusBarFileNum.Size = new System.Drawing.Size(0, 17);
            // 
            // fileEntryCountLabel
            // 
            this.fileEntryCountLabel.Name = "fileEntryCountLabel";
            this.fileEntryCountLabel.Size = new System.Drawing.Size(29, 17);
            this.fileEntryCountLabel.Text = "Tree";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 49);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.directoryTreeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listViewFiles);
            this.splitContainer.Size = new System.Drawing.Size(984, 450);
            this.splitContainer.SplitterDistance = 327;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 3;
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryTreeView.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryTreeView.ImageIndex = 0;
            this.directoryTreeView.ImageList = this.listIcons;
            this.directoryTreeView.Location = new System.Drawing.Point(0, 0);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.SelectedImageIndex = 0;
            this.directoryTreeView.Size = new System.Drawing.Size(327, 450);
            this.directoryTreeView.TabIndex = 0;
            this.directoryTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.DirectoryTreeView_BeforeExpand);
            this.directoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirectoryTreeView_AfterSelect);
            // 
            // listViewFiles
            // 
            this.listViewFiles.AllowDrop = true;
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColHeader,
            this.lastModifiedColHeader,
            this.typeColHeader,
            this.sizeColHeader});
            this.listViewFiles.ContextMenuStrip = this.mainContextMenuStrip;
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.LabelEdit = true;
            this.listViewFiles.Location = new System.Drawing.Point(0, 0);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(652, 450);
            this.listViewFiles.SmallImageList = this.listIcons;
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListViewFiles_AfterLabelEdit);
            this.listViewFiles.ItemActivate += new System.EventHandler(this.ListViewFiles_ItemActivate);
            // 
            // nameColHeader
            // 
            this.nameColHeader.Text = "Name";
            this.nameColHeader.Width = 260;
            // 
            // lastModifiedColHeader
            // 
            this.lastModifiedColHeader.Text = "Last modified";
            this.lastModifiedColHeader.Width = 133;
            // 
            // typeColHeader
            // 
            this.typeColHeader.Text = "Type";
            this.typeColHeader.Width = 77;
            // 
            // sizeColHeader
            // 
            this.sizeColHeader.Text = "Size";
            this.sizeColHeader.Width = 140;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileTsmi;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton upArrowBtn;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyTsmi;
        private System.Windows.Forms.ToolStripMenuItem pasteContexMenu;
        private System.Windows.Forms.ToolStripMenuItem cutTsmi;
        private System.Windows.Forms.ToolStripMenuItem deleteTsmi;
        private System.Windows.Forms.ToolStripMenuItem renameTsmi;
        private System.Windows.Forms.ToolStripMenuItem newFolderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem propertiesTsmi;
        private System.Windows.Forms.ImageList listIcons;
        private System.Windows.Forms.ToolStripMenuItem viewTsmi;
        private System.Windows.Forms.ToolStripMenuItem refreshMainTsmi;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ToolStripStatusLabel statusBarFileNum;
        private System.Windows.Forms.ToolStripComboBox addressInput;
        private System.Windows.Forms.ColumnHeader nameColHeader;
        private System.Windows.Forms.ColumnHeader lastModifiedColHeader;
        private System.Windows.Forms.ColumnHeader typeColHeader;
        private System.Windows.Forms.ColumnHeader sizeColHeader;
        private System.Windows.Forms.ToolStripMenuItem newFolderMainTsmi;
        private System.Windows.Forms.ToolStripMenuItem newFileMainTsmi;
        private System.Windows.Forms.ToolStripComboBox searchInput;
        private System.Windows.Forms.ToolStripMenuItem pasteMainTsmi;
        private System.Windows.Forms.ToolStripMenuItem hiddenFilesTsmi;
        private System.Windows.Forms.ToolStripMenuItem newFileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshContextMenu;
        private System.Windows.Forms.ToolStripMenuItem fileTreeCountTsmi;
        private System.Windows.Forms.ToolStripStatusLabel fileEntryCountLabel;
    }
}

