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
            this.mMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mFileTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mNewFolderMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mNewFileMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mPasteMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mRefreshMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mHiddenFilesTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mStopBackgroundThreads = new System.Windows.Forms.ToolStripMenuItem();
            this.mMainToolStrip = new System.Windows.Forms.ToolStrip();
            this.mUpArrowBtn = new System.Windows.Forms.ToolStripButton();
            this.mAddressInput = new System.Windows.Forms.ToolStripComboBox();
            this.mSearchInput = new System.Windows.Forms.ToolStripComboBox();
            this.mMainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mNewFolderContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mNewFileContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopyTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mPasteContexMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mCutTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeleteTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mRenameTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mRefreshContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mPropertiesTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.mListIcons = new System.Windows.Forms.ImageList(this.components);
            this.mStatusBar = new System.Windows.Forms.StatusStrip();
            this.mStatusBarFileNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.mDirectoryTreeView = new System.Windows.Forms.TreeView();
            this.mListViewFiles = new System.Windows.Forms.ListView();
            this.mNameColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mLastModifiedColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mTypeColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mSizeColHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mMainMenuStrip.SuspendLayout();
            this.mMainToolStrip.SuspendLayout();
            this.mMainContextMenuStrip.SuspendLayout();
            this.mStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMainMenuStrip
            // 
            this.mMainMenuStrip.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileTsmi,
            this.mViewTsmi,
            this.mStopBackgroundThreads});
            this.mMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mMainMenuStrip.Name = "mMainMenuStrip";
            this.mMainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mMainMenuStrip.Size = new System.Drawing.Size(899, 25);
            this.mMainMenuStrip.TabIndex = 0;
            this.mMainMenuStrip.Text = "menuStrip1";
            // 
            // mFileTsmi
            // 
            this.mFileTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNewFolderMain,
            this.mNewFileMain,
            this.mPasteMain});
            this.mFileTsmi.Name = "mFileTsmi";
            this.mFileTsmi.Size = new System.Drawing.Size(39, 21);
            this.mFileTsmi.Text = "File";
            // 
            // mNewFolderMain
            // 
            this.mNewFolderMain.Name = "mNewFolderMain";
            this.mNewFolderMain.Size = new System.Drawing.Size(141, 22);
            this.mNewFolderMain.Text = "New folder";
            this.mNewFolderMain.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // mNewFileMain
            // 
            this.mNewFileMain.Name = "mNewFileMain";
            this.mNewFileMain.Size = new System.Drawing.Size(141, 22);
            this.mNewFileMain.Text = "New file";
            this.mNewFileMain.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // mPasteMain
            // 
            this.mPasteMain.Name = "mPasteMain";
            this.mPasteMain.Size = new System.Drawing.Size(141, 22);
            this.mPasteMain.Text = "Paste";
            this.mPasteMain.Click += new System.EventHandler(this.Paste_Click);
            // 
            // mViewTsmi
            // 
            this.mViewTsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRefreshMain,
            this.mHiddenFilesTsmi});
            this.mViewTsmi.Name = "mViewTsmi";
            this.mViewTsmi.Size = new System.Drawing.Size(47, 21);
            this.mViewTsmi.Text = "View";
            // 
            // mRefreshMain
            // 
            this.mRefreshMain.Name = "mRefreshMain";
            this.mRefreshMain.Size = new System.Drawing.Size(145, 22);
            this.mRefreshMain.Text = "Refresh";
            this.mRefreshMain.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // mHiddenFilesTsmi
            // 
            this.mHiddenFilesTsmi.CheckOnClick = true;
            this.mHiddenFilesTsmi.Name = "mHiddenFilesTsmi";
            this.mHiddenFilesTsmi.Size = new System.Drawing.Size(145, 22);
            this.mHiddenFilesTsmi.Text = "Hidden files";
            this.mHiddenFilesTsmi.CheckStateChanged += new System.EventHandler(this.HiddenFilesTsmi_CheckStateChanged);
            // 
            // mStopBackgroundThreads
            // 
            this.mStopBackgroundThreads.Name = "mStopBackgroundThreads";
            this.mStopBackgroundThreads.Size = new System.Drawing.Size(58, 21);
            this.mStopBackgroundThreads.Text = "Cancel";
            this.mStopBackgroundThreads.Visible = false;
            this.mStopBackgroundThreads.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // mMainToolStrip
            // 
            this.mMainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mMainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUpArrowBtn,
            this.mAddressInput,
            this.mSearchInput});
            this.mMainToolStrip.Location = new System.Drawing.Point(0, 25);
            this.mMainToolStrip.Name = "mMainToolStrip";
            this.mMainToolStrip.Size = new System.Drawing.Size(899, 27);
            this.mMainToolStrip.TabIndex = 1;
            this.mMainToolStrip.Text = "toolStrip1";
            // 
            // mUpArrowBtn
            // 
            this.mUpArrowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mUpArrowBtn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mUpArrowBtn.Image = global::FileExplorer.Resource.up_arrow;
            this.mUpArrowBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.mUpArrowBtn.Name = "mUpArrowBtn";
            this.mUpArrowBtn.Size = new System.Drawing.Size(23, 24);
            this.mUpArrowBtn.Click += new System.EventHandler(this.UpArrowBtn_Click);
            // 
            // mAddressInput
            // 
            this.mAddressInput.AutoSize = false;
            this.mAddressInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mAddressInput.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAddressInput.ForeColor = System.Drawing.Color.Black;
            this.mAddressInput.Name = "mAddressInput";
            this.mAddressInput.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.mAddressInput.Size = new System.Drawing.Size(700, 25);
            this.mAddressInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressInput_KeyDown);
            // 
            // mSearchInput
            // 
            this.mSearchInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mSearchInput.Name = "mSearchInput";
            this.mSearchInput.Size = new System.Drawing.Size(160, 23);
            this.mSearchInput.Text = "Search...";
            this.mSearchInput.Enter += new System.EventHandler(this.SearchInput_Enter);
            this.mSearchInput.Leave += new System.EventHandler(this.SearchInput_Leave);
            this.mSearchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInput_KeyDown);
            // 
            // mMainContextMenuStrip
            // 
            this.mMainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNewFolderContextMenu,
            this.mNewFileContextMenu,
            this.mCopyTsmi,
            this.mPasteContexMenu,
            this.mCutTsmi,
            this.mDeleteTsmi,
            this.mRenameTsmi,
            this.mRefreshContextMenu,
            this.mPropertiesTsmi});
            this.mMainContextMenuStrip.Name = "contextMenuStrip1";
            this.mMainContextMenuStrip.Size = new System.Drawing.Size(133, 202);
            this.mMainContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MainContextMenuStrip_Opening);
            // 
            // mNewFolderContextMenu
            // 
            this.mNewFolderContextMenu.Name = "mNewFolderContextMenu";
            this.mNewFolderContextMenu.Size = new System.Drawing.Size(132, 22);
            this.mNewFolderContextMenu.Text = "New folder";
            this.mNewFolderContextMenu.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // mNewFileContextMenu
            // 
            this.mNewFileContextMenu.Name = "mNewFileContextMenu";
            this.mNewFileContextMenu.Size = new System.Drawing.Size(132, 22);
            this.mNewFileContextMenu.Text = "New file";
            this.mNewFileContextMenu.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // mCopyTsmi
            // 
            this.mCopyTsmi.Name = "mCopyTsmi";
            this.mCopyTsmi.Size = new System.Drawing.Size(132, 22);
            this.mCopyTsmi.Text = "Copy";
            this.mCopyTsmi.Click += new System.EventHandler(this.Copy_Click);
            // 
            // mPasteContexMenu
            // 
            this.mPasteContexMenu.Name = "mPasteContexMenu";
            this.mPasteContexMenu.Size = new System.Drawing.Size(132, 22);
            this.mPasteContexMenu.Text = "Paste";
            this.mPasteContexMenu.Click += new System.EventHandler(this.Paste_Click);
            // 
            // mCutTsmi
            // 
            this.mCutTsmi.Name = "mCutTsmi";
            this.mCutTsmi.Size = new System.Drawing.Size(132, 22);
            this.mCutTsmi.Text = "Cut";
            this.mCutTsmi.Click += new System.EventHandler(this.Cut_Click);
            // 
            // mDeleteTsmi
            // 
            this.mDeleteTsmi.Name = "mDeleteTsmi";
            this.mDeleteTsmi.Size = new System.Drawing.Size(132, 22);
            this.mDeleteTsmi.Text = "Delete";
            this.mDeleteTsmi.Click += new System.EventHandler(this.Delete_Click);
            // 
            // mRenameTsmi
            // 
            this.mRenameTsmi.Name = "mRenameTsmi";
            this.mRenameTsmi.Size = new System.Drawing.Size(132, 22);
            this.mRenameTsmi.Text = "Rename";
            this.mRenameTsmi.Click += new System.EventHandler(this.Rename_Click);
            // 
            // mRefreshContextMenu
            // 
            this.mRefreshContextMenu.Name = "mRefreshContextMenu";
            this.mRefreshContextMenu.Size = new System.Drawing.Size(132, 22);
            this.mRefreshContextMenu.Text = "Refresh";
            this.mRefreshContextMenu.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // mPropertiesTsmi
            // 
            this.mPropertiesTsmi.Name = "mPropertiesTsmi";
            this.mPropertiesTsmi.Size = new System.Drawing.Size(132, 22);
            this.mPropertiesTsmi.Text = "Properties";
            this.mPropertiesTsmi.Click += new System.EventHandler(this.Properties_Click);
            // 
            // mListIcons
            // 
            this.mListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mListIcons.ImageSize = new System.Drawing.Size(20, 20);
            this.mListIcons.TransparentColor = System.Drawing.SystemColors.Control;
            // 
            // mStatusBar
            // 
            this.mStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStatusBarFileNum});
            this.mStatusBar.Location = new System.Drawing.Point(0, 509);
            this.mStatusBar.Name = "mStatusBar";
            this.mStatusBar.Size = new System.Drawing.Size(899, 22);
            this.mStatusBar.TabIndex = 2;
            // 
            // mStatusBarFileNum
            // 
            this.mStatusBarFileNum.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mStatusBarFileNum.Name = "mStatusBarFileNum";
            this.mStatusBarFileNum.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 52);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.mDirectoryTreeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.mListViewFiles);
            this.splitContainer.Size = new System.Drawing.Size(899, 457);
            this.splitContainer.SplitterDistance = 299;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 3;
            // 
            // mDirectoryTreeView
            // 
            this.mDirectoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mDirectoryTreeView.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mDirectoryTreeView.ImageIndex = 0;
            this.mDirectoryTreeView.ImageList = this.mListIcons;
            this.mDirectoryTreeView.Location = new System.Drawing.Point(0, 0);
            this.mDirectoryTreeView.Name = "mDirectoryTreeView";
            this.mDirectoryTreeView.SelectedImageIndex = 0;
            this.mDirectoryTreeView.Size = new System.Drawing.Size(299, 457);
            this.mDirectoryTreeView.TabIndex = 0;
            this.mDirectoryTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.DirectoryTreeView_BeforeExpand);
            this.mDirectoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirectoryTreeView_AfterSelect);
            // 
            // mListViewFiles
            // 
            this.mListViewFiles.AllowDrop = true;
            this.mListViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mNameColHeader,
            this.mLastModifiedColHeader,
            this.mTypeColHeader,
            this.mSizeColHeader});
            this.mListViewFiles.ContextMenuStrip = this.mMainContextMenuStrip;
            this.mListViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mListViewFiles.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mListViewFiles.FullRowSelect = true;
            this.mListViewFiles.LabelEdit = true;
            this.mListViewFiles.Location = new System.Drawing.Point(0, 0);
            this.mListViewFiles.Name = "mListViewFiles";
            this.mListViewFiles.Size = new System.Drawing.Size(595, 457);
            this.mListViewFiles.SmallImageList = this.mListIcons;
            this.mListViewFiles.TabIndex = 0;
            this.mListViewFiles.UseCompatibleStateImageBehavior = false;
            this.mListViewFiles.View = System.Windows.Forms.View.Details;
            this.mListViewFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ListViewFiles_AfterLabelEdit);
            this.mListViewFiles.ItemActivate += new System.EventHandler(this.ListViewFiles_ItemActivate);
            // 
            // mNameColHeader
            // 
            this.mNameColHeader.Text = "Name";
            this.mNameColHeader.Width = 260;
            // 
            // mLastModifiedColHeader
            // 
            this.mLastModifiedColHeader.Text = "Last modified";
            this.mLastModifiedColHeader.Width = 116;
            // 
            // mTypeColHeader
            // 
            this.mTypeColHeader.Text = "Type";
            this.mTypeColHeader.Width = 77;
            // 
            // mSizeColHeader
            // 
            this.mSizeColHeader.Text = "Size";
            this.mSizeColHeader.Width = 140;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 531);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mStatusBar);
            this.Controls.Add(this.mMainToolStrip);
            this.Controls.Add(this.mMainMenuStrip);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mMainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.mMainMenuStrip.ResumeLayout(false);
            this.mMainMenuStrip.PerformLayout();
            this.mMainToolStrip.ResumeLayout(false);
            this.mMainToolStrip.PerformLayout();
            this.mMainContextMenuStrip.ResumeLayout(false);
            this.mStatusBar.ResumeLayout(false);
            this.mStatusBar.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mFileTsmi;
        private System.Windows.Forms.ToolStrip mMainToolStrip;
        private System.Windows.Forms.ToolStripButton mUpArrowBtn;
        private System.Windows.Forms.ContextMenuStrip mMainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mCopyTsmi;
        private System.Windows.Forms.ToolStripMenuItem mPasteContexMenu;
        private System.Windows.Forms.ToolStripMenuItem mCutTsmi;
        private System.Windows.Forms.ToolStripMenuItem mDeleteTsmi;
        private System.Windows.Forms.ToolStripMenuItem mRenameTsmi;
        private System.Windows.Forms.ToolStripMenuItem mNewFolderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mPropertiesTsmi;
        private System.Windows.Forms.ImageList mListIcons;
        private System.Windows.Forms.ToolStripMenuItem mViewTsmi;
        private System.Windows.Forms.ToolStripMenuItem mRefreshMain;
        private System.Windows.Forms.StatusStrip mStatusBar;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView mDirectoryTreeView;
        private System.Windows.Forms.ListView mListViewFiles;
        private System.Windows.Forms.ToolStripStatusLabel mStatusBarFileNum;
        private System.Windows.Forms.ToolStripComboBox mAddressInput;
        private System.Windows.Forms.ColumnHeader mNameColHeader;
        private System.Windows.Forms.ColumnHeader mLastModifiedColHeader;
        private System.Windows.Forms.ColumnHeader mTypeColHeader;
        private System.Windows.Forms.ColumnHeader mSizeColHeader;
        private System.Windows.Forms.ToolStripMenuItem mNewFolderMain;
        private System.Windows.Forms.ToolStripMenuItem mNewFileMain;
        private System.Windows.Forms.ToolStripComboBox mSearchInput;
        private System.Windows.Forms.ToolStripMenuItem mPasteMain;
        private System.Windows.Forms.ToolStripMenuItem mHiddenFilesTsmi;
        private System.Windows.Forms.ToolStripMenuItem mNewFileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mRefreshContextMenu;
        private System.Windows.Forms.ToolStripMenuItem mStopBackgroundThreads;
    }
}

