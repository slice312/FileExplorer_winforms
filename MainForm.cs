using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;


namespace FileExplorer
{
    public partial class MainForm : Form
    {
        //Текущий путь.
        private string mCurrentPath;

        //Выбранный узел дерева с директориями.
        private TreeNode mCurSelectedNode;

        //Для перемещения файлов.
        private bool mIsMove;

        //Показывать скрытые файлы.
        private bool mShowHidden;

        //Исходный путь к файлам для копирования и вставки.
        private readonly List<string> mListSourcesPath;

        //Хранит записи при поиске, чтобы сразу не помещать на ListView.
        private LinkedList<(string, bool)> mTmpItemList;

        //Имя файла для поиска.
        private string mSearchFileName;

        //Дерево со всеми файловыми записями.
        private TreeItem mFileTree;


        public MainForm()
        {
            ClosePreviousInstance();
            mListSourcesPath = new List<string>(200);
            mListSourcesPath.Clear();
            mTmpItemList = new LinkedList<(string, bool)>();
            mTmpItemList.Clear();
            mIsMove = false;
            mShowHidden = false;
            mCurSelectedNode = null;
            mCurrentPath = string.Empty;
            mSearchFileName = string.Empty;

            InitializeComponent();
            InitDisplay();
        }


        public void ClosePreviousInstance()
        {
            Process[] pname = Process.GetProcessesByName(AppDomain
                .CurrentDomain
                .FriendlyName
                .Remove(AppDomain.CurrentDomain.FriendlyName.Length - 4));

            if (pname.Length > 1)
                pname.First(p => p.Id != Process.GetCurrentProcess().Id).Kill();
        }


        protected override void OnResize(EventArgs e)
        {
            mAddressInput.Width = Width - 290;
        }


        private void NewFolder_Click(object sender, EventArgs e)
        {
            Console.WriteLine("NewFolder_Click");
            try
            {
                string path = Path.Combine(mCurrentPath, "New folder");
                string newFolderPath = path;

                int num = 1;
                while (Directory.Exists(newFolderPath))
                {
                    newFolderPath = path + " (" + num + ")";
                    num++;
                }

                DirectoryInfo dirInfo = Directory.CreateDirectory(newFolderPath);
                AddItemOnListView(dirInfo.FullName, false);

                LoadChildNodes(mCurSelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void NewFile_Click(object sender, EventArgs e)
        {
            Console.WriteLine("NewFile_Click");
            NewFileForm newFileForm = new NewFileForm(mCurrentPath);
            newFileForm.ShowDialog();
            ShowFilesList(mCurrentPath);
        }


        private void Copy_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Copy_Click");
            SetCopyFilesSourcePaths();
            mIsMove = false;
        }


        private void Cut_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Cut_Click");
            SetCopyFilesSourcePaths();
            mIsMove = true;
        }


        private void Paste_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Paste_Click");

            //Нет файлов для вставки.
            if (!mListSourcesPath.Any())
                return;

            foreach (string path in mListSourcesPath)
            {
                if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
                    MoveToOrCopyToDirectoryBySourcePath(path);
                else
                    MoveToOrCopyToFileBySourcePath(path);
            }

            //Обновить виджеты.
            ShowFilesList(mCurrentPath);
            LoadChildNodes(mCurSelectedNode);
        }


        private void Rename_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Rename_Click");
            if (mListViewFiles.SelectedItems.Count > 0)
                mListViewFiles.SelectedItems[0].BeginEdit();
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Delete_Click");

            if (mListViewFiles.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete?",
                    "Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                );

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        foreach (ListViewItem item in mListViewFiles.SelectedItems)
                        {
                            string path = item.Tag.ToString();

                            if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
                                Directory.Delete(path, true);
                            else
                                File.Delete(path);

                            mListViewFiles.Items.Remove(item);
                        }

                        LoadChildNodes(mCurSelectedNode);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(ex.StackTrace);
                    }
                }
            }
        }


        private void Refresh_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Refresh_Click");
            ShowFilesList(mCurrentPath);
        }


        private void HiddenFilesTsmi_CheckStateChanged(object sender, EventArgs e)
        {
            mShowHidden = mHiddenFilesTsmi.Checked;
            ShowFilesList(mCurrentPath);
        }


        private void FileTreeCountTsmi_Click(object sender, EventArgs e)
        {
            mFileEntryCountLabel.Text = TreeItem.Count.ToString();

        }


        private void Properties_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Properties_Click");

            PropertiesForm form;
            //Нет выбранных файлов\папок.
            if (mListViewFiles.SelectedItems.Count == 0)
            {
                //Показать свойства текущей папки.
                form = new PropertiesForm(mCurrentPath);
            }
            else
            {
                // Показать свойства первого выбранного файла
                form = new PropertiesForm(mListViewFiles.SelectedItems[0].Tag.ToString());
            }

            form.Show();
        }


        private void MainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Console.WriteLine("MainContextMenuStrip_Opening");

            //Получить координаты курсора.
            Point curPoint = mListViewFiles.PointToClient(Cursor.Position);

            //Получить ListViewItem по координатам курсора.
            ListViewItem item = mListViewFiles.GetItemAt(curPoint.X, curPoint.Y);

            //Если курсор на итеме.
            if (item != null)
            {
                mCopyTsmi.Visible = true;
                mPasteContexMenu.Visible = true;
                mCutTsmi.Visible = true;
                mDeleteTsmi.Visible = true;
                mRenameTsmi.Visible = true;
                mNewFolderContextMenu.Visible = true;
            }
            else
            {
                mCopyTsmi.Visible = false;
                mPasteContexMenu.Visible = true;
                mCutTsmi.Visible = false;
                mDeleteTsmi.Visible = false;
                mRenameTsmi.Visible = false;
                mNewFolderContextMenu.Visible = true;
            }
        }


        //Перейти вверх на 1 уровень.
        private void UpArrowBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("UpArrowBtn_Click");
            DirectoryInfo directoryInfo = new DirectoryInfo(mCurrentPath);

            if (directoryInfo.Parent != null)
                ShowFilesList(directoryInfo.Parent.FullName);
        }


        private void AddressInput_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("AddressInput_KeyDown");

            if (e.KeyCode == Keys.Enter)
            {
                string newPath = mAddressInput.Text;

                if (string.IsNullOrEmpty(newPath) || !Directory.Exists(newPath))
                    return;
                ShowFilesList(newPath);
            }
        }


        private void ListViewFiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            Console.WriteLine("ListViewFiles_AfterLabelEdit");
            if (string.IsNullOrEmpty(e.Label))
            {
                e.CancelEdit = true;
                return;
            }

            string newName = e.Label;
            ListViewItem selectedItem = mListViewFiles.SelectedItems[0];

            //Если имя не изменилось.
            if (newName == selectedItem.Text)
            {
                return;
            }
            else if (!FileSystem.IsValidFileName(newName))
            {
                MessageBox.Show("The file name can't contain any of the following characters:\n" + "\t\\/:*?\"<>|",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.CancelEdit = true;
            }
            else
            {
                Computer computer = new Computer();

                if (File.GetAttributes(selectedItem.Tag.ToString()).HasFlag(FileAttributes.Directory))
                {
                    //Если уже есть папка с таким именем.
                    if (Directory.Exists(Path.Combine(mCurrentPath, newName)))
                    {
                        MessageBox.Show("Target folder already contains a folder with that name！", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        e.CancelEdit = true;
                    }
                    else
                    {
                        computer.FileSystem.RenameDirectory(selectedItem.Tag.ToString(), newName);

                        //Обновить тэг выбранного элемента.
                        DirectoryInfo directoryInfo = new DirectoryInfo(selectedItem.Tag.ToString());
                        string parentPath = directoryInfo.Parent.FullName;
                        string newPath = Path.Combine(parentPath, newName);
                        selectedItem.Tag = newPath;
                    }
                }
                else
                {
                    //Если уже есть файл с таким именем.
                    if (File.Exists(Path.Combine(mCurrentPath, newName)))
                    {
                        MessageBox.Show("Target folder already contains a file with that name！", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        e.CancelEdit = true;
                    }
                    else
                    {
                        computer.FileSystem.RenameFile(selectedItem.Tag.ToString(), newName);

                        //Обновить тэг выбранного элемента.
                        FileInfo fileInfo = new FileInfo(selectedItem.Tag.ToString());
                        string parentPath = Path.GetDirectoryName(fileInfo.FullName);
                        string newPath = Path.Combine(parentPath, newName);
                        selectedItem.Tag = newPath;
                    }
                }
            }

            LoadChildNodes(mCurSelectedNode);
            ShowFilesList(mCurrentPath);
        }


        //Двойное нажатие по ListViewItem.
        private void ListViewFiles_ItemActivate(object sender, EventArgs e)
        {
            Console.WriteLine("ListViewFiles_ItemActivate");
            Open();
        }


        //При выборе узла на TreeView, обновляет список файлов ListView для этого узла.
        private void DirectoryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine("DirectoryTreeView_AfterSelect");
            mCurSelectedNode = e.Node;
            ShowFilesList(e.Node.Tag.ToString());
        }

        private void DirectoryTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Console.WriteLine("DirectoryTreeView_BeforeExpand");
            //Загрузить дочерние узлы выбранного узла до того, как он будет развернут.
            LoadChildNodes(e.Node);
        }


        private void SearchInput_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("SearchInput_Enter");
            mSearchInput.Text = String.Empty;
        }

        private void SearchInput_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("SearchInput_Leave");
            mSearchInput.Text = "Search:";
        }

        private void SearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("SearchInput_KeyDown");

            if (e.KeyCode == Keys.Enter)
            {
                string fileName = mSearchInput.Text;
                if (string.IsNullOrEmpty(fileName))
                    return;

                mTmpItemList.Clear();
                mListViewFiles.Items.Clear();
                mStatusBarFileNum.Text = "0 items";
                mSearchFileName = fileName.ToLower();

                Search();
            }
        }


        private void InitDisplay()
        {
            Console.WriteLine("InitDisplay");
            try
            {
                ThreadPool.SetMaxThreads(25, 25);

                Icon driveIcon = ShellIcon.GetDriveIcon();
                mListIcons.Images.Add("drive", driveIcon);

                mFileTree = new TreeItem("ROOT", null);

                foreach (DriveInfo info in DriveInfo.GetDrives())
                {
                    string label = (info.VolumeLabel == string.Empty) ? "Disk" : info.VolumeLabel;
                    label += $"({info.Name.Split('\\')[0]})";
                    TreeNode driveNode = mDirectoryTreeView.Nodes.Add(label);
                    driveNode.Tag = info.Name;
                    driveNode.ImageKey = "drive";
                    driveNode.Nodes.Add(string.Empty); //Добавляю пустой узел, чтобы появился значок '+'.

                    //https://stackoverflow.com/questions/5188527/how-to-deal-with-files-with-a-name-longer-than-259-characters
                    TreeItem childNode = new TreeItem(@"\\?\" + info.Name, mFileTree);
                    mFileTree.AddChild(childNode);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadFileTree), childNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }

            //Для всех папок одинаковая иконка.
            Icon folderIcon = ShellIcon.GetFolderIcon();
            mListIcons.Images.Add("folder", folderIcon);
        }


        //Загрузить подкаталоги в текущем каталоге. (для TreeView)
        private void LoadChildNodes(TreeNode node)
        {
            Console.WriteLine("\t\t\t\t\t\tLoadChildNodes");
            try
            {
                //Очистите пустые узлы перед загрузкой дочерних узлов.
                node.Nodes.Clear();

                DirectoryInfo directoryInfo = new DirectoryInfo(node.Tag.ToString());

                //Cписок папок.
                foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
                {
//                    DirectorySecurity security = Directory.GetAccessControl(dir.FullName);
//                    if (security.AreAccessRulesProtected)
//                        continue;

                    var attr = File.GetAttributes(dir.FullName);
                    if (attr.HasFlag(FileAttributes.System)
                        || (attr.HasFlag(FileAttributes.Hidden) && !mShowHidden))
                    {
                        continue;
                    }

                    TreeNode childNode = node.Nodes.Add(dir.Name);
                    childNode.Tag = dir.FullName;
                    childNode.ImageKey = "folder";
                    childNode.Nodes.Add(string.Empty); //Добавляю пустой узел, чтобы появился значок '+'.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }


        //TODO загрузка в дерево для поиска
        private void LoadFileTree(object _node)
        {
            TreeItem node = (TreeItem) _node;

            foreach (string entry in Directory.GetFileSystemEntries(node.ItemData))
            {
                if (entry == @"\\?\C:\Windows") continue;

                FileAttributes attr = File.GetAttributes(entry);
                if (attr.HasFlag(FileAttributes.System)
                    || (attr.HasFlag(FileAttributes.Hidden) && !mShowHidden))
                {
                    continue;
                }

                TreeItem childNode;

                if (attr.HasFlag(FileAttributes.Directory))
                {
//                    DirectorySecurity security = Directory.GetAccessControl(entry);
//                        if (security.AreAccessRulesProtected) continue;
                    childNode = new TreeItem(entry, node);
                    node.AddChild(childNode);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(LoadFileTree), childNode);
                }
                else
                {
                    childNode = new TreeItem(entry, node);
                    node.AddChild(childNode);
                }
            }
        }


        //Загрузить список файлов на ListView
        public void ShowFilesList(string path)
        {
            Console.WriteLine("\t\t\t\t\t\tShowFilesList");
            //BeginUpdate, EndUpdate - нужны при добавление большого количества элементов,
            //чтобы не перерисовывало после каждого.
            mListViewFiles.BeginUpdate();
            mListViewFiles.Items.Clear();

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                //Cписок папок.
                foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
                {
//                    DirectorySecurity security = Directory.GetAccessControl(dir.FullName);
//                    if (security.AreAccessRulesProtected)
//                        continue;

                    var attr = File.GetAttributes(dir.FullName);
                    if (attr.HasFlag(FileAttributes.System)
                        || (attr.HasFlag(FileAttributes.Hidden) && !mShowHidden))
                    {
                        continue;
                    }

                    AddItemOnListView(dir.FullName, false);
                }

                //Cписок файлов.
                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    var attr = File.GetAttributes(file.FullName);
                    if (attr.HasFlag(FileAttributes.System)
                        || (attr.HasFlag(FileAttributes.Hidden) && !mShowHidden))
                    {
                        continue;
                    }

                    AddItemOnListView(file.FullName, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }

            //Обновить текущий путь и адресную строку.
            mCurrentPath = path;
            mAddressInput.Text = mCurrentPath;
            //Количество файлов\папок в статус бар.  //TODO добавить событие selected items
            mStatusBarFileNum.Text = mListViewFiles.Items.Count + " items";
            mListViewFiles.EndUpdate();
        }


        private void AddItemOnListView(string fullPath, bool isFile)
        {
            if (isFile)
            {
                FileInfo fileInfo = new FileInfo(fullPath);

                ListViewItem item = mListViewFiles.Items.Add(fileInfo.Name);

                //Исполняемые файлы и ярлыки могут иметь разные иконки.
                if (fileInfo.Extension == ".exe" || fileInfo.Extension == ".lnk" ||
                    fileInfo.Extension == string.Empty)
                {
                    if (!mListIcons.Images.ContainsKey(fileInfo.FullName))
                    {
                        Icon fileIcon = ShellIcon.GetLargeIcon(fileInfo.FullName);
                        mListIcons.Images.Add(fileInfo.FullName, fileIcon);
                    }

                    item.ImageKey = fileInfo.FullName;
                }
                else
                {
                    //Для остальных типов, иконка одинаковая для всех файлов этого расширения.
                    if (!mListIcons.Images.ContainsKey(fileInfo.Extension))
                    {
                        Icon fileIcon = ShellIcon.GetLargeIcon(fileInfo.FullName);
                        mListIcons.Images.Add(fileInfo.Extension, fileIcon);
                    }

                    item.ImageKey = fileInfo.Extension;
                }

                item.Tag = fileInfo.FullName;
                item.SubItems.Add(fileInfo.LastWriteTime.ToString("dd.mm.yyyy HH:mm"));
                item.SubItems.Add(string.IsNullOrEmpty(fileInfo.Extension) ? "File" : fileInfo.Extension);
                item.SubItems.Add(FileSystem.FileSizeStr(fileInfo.Length));
            }
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
                ListViewItem item = mListViewFiles.Items.Add(dirInfo.Name, "folder");
                item.Tag = dirInfo.FullName;
                item.SubItems.Add(dirInfo.LastWriteTime.ToString("dd.mm.yyyy HH:mm"));
                item.SubItems.Add("Folder");
                item.SubItems.Add(string.Empty); //Для папок считать размер слишком долго.
            }
        }


        private void Open()
        {
            Console.WriteLine("\t\t\t\t\t\tOpen");

            if (mListViewFiles.SelectedItems.Count > 0)
            {
                try
                {
                    string path = mListViewFiles.SelectedItems[0].Tag.ToString();
                    if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
                    {
                        //Открыть папку.
                        ShowFilesList(path);
                    }
                    else
                    {
                        //Открыть файл.
                        Process.Start(path);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }


        //Получить пути к файлам для копирования.
        private void SetCopyFilesSourcePaths()
        {
            Console.WriteLine("\t\t\t\t\t\tSetCopyFilesSourcePaths");

            if (mListViewFiles.SelectedItems.Count > 0)
            {
                mListSourcesPath.Clear();
                foreach (ListViewItem item in mListViewFiles.SelectedItems)
                    mListSourcesPath.Add(item.Tag.ToString());
            }
        }


        private void MoveToOrCopyToFileBySourcePath(string sourcePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                string destPath = Path.Combine(mCurrentPath, fileInfo.Name);

                if (destPath == sourcePath || File.Exists(destPath))
                {
                    string path = Path.Combine(fileInfo.DirectoryName,
                        Path.GetFileNameWithoutExtension(fileInfo.FullName));
                    int num = 1;
                    while (File.Exists(destPath))
                    {
                        destPath = path + $" - Copy ({num++}){fileInfo.Extension}";
                    }
                }

                if (mIsMove)
                    fileInfo.MoveTo(destPath);
                else
                    fileInfo.CopyTo(destPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }


        private void MoveToOrCopyToDirectoryBySourcePath(string sourcePath)
        {
            try
            {
                DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourcePath);
                string destPath = Path.Combine(mCurrentPath, sourceDirectoryInfo.Name);

                if (destPath == sourcePath || Directory.Exists(destPath))
                {
                    string path = destPath;
                    int num = 1;
                    while (Directory.Exists(destPath))
                    {
                        destPath = path + $" - Copy ({num++})";
                    }
                }

                if (mIsMove)
                {
                    FileSystem.CopyAndPasteDirectory(sourceDirectoryInfo, new DirectoryInfo(destPath));
                    Directory.Delete(sourcePath, true);
                }
                else
                {
                    FileSystem.CopyAndPasteDirectory(sourceDirectoryInfo, new DirectoryInfo(destPath));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }


        public void Search()
        {
            mListViewFiles.BeginUpdate();

            Search(mCurrentPath);
            foreach ((string, bool) tuple in mTmpItemList)
            {
                AddItemOnListView(tuple.Item1, tuple.Item2);
            }

            mStatusBarFileNum.Text = $"{mListViewFiles.Items.Count} items";
            mListViewFiles.EndUpdate();
        }


        public void Search(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

            //Поиск среди файлов.
            foreach (FileInfo file in fileInfos)
            {
                var attr = File.GetAttributes(file.FullName);
                if (attr.HasFlag(FileAttributes.System)
                    || (attr.HasFlag(FileAttributes.Hidden) && !mShowHidden))
                {
                    continue;
                }

                if (file.Name.ToLower().Contains(mSearchFileName))
                {
                    mTmpItemList.AddLast((file.FullName, true));
                    //                    AddItemOnListView(file.FullName, true);
                    //                    mStatusBarFileNum.Text = $"{mListViewFiles.Items.Count} items";
                }
            }


            //Поиск среди папок.
            foreach (DirectoryInfo dir in directoryInfos)
            {
                var attr = File.GetAttributes(dir.FullName);
                if (attr.HasFlag(FileAttributes.System)
                    || (attr.HasFlag(FileAttributes.Hidden) && !mShowHidden))
                {
                    continue;
                }


                if (dir.Name.ToLower().Contains(mSearchFileName))
                {
                    mTmpItemList.AddLast((dir.FullName, false));
                    //                    AddItemOnListView(dir.FullName, false);
                    //                    mStatusBarFileNum.Text = $"{mListViewFiles.Items.Count} items";
                }

                Search(dir.FullName);
            }
        }

      
    }
}