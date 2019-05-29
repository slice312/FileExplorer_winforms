using System;
using System.IO;
using System.Windows.Forms;


namespace FileExplorer
{
    public partial class PropertiesForm : Form
    {
        public PropertiesForm(string filePath)
        {
            InitializeComponent();
            InitDisplay(filePath);
        }


        private void InitDisplay(string filePath)
        {
            if (File.GetAttributes(filePath).HasFlag(FileAttributes.Directory))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

                mNameTextBox.Text = directoryInfo.Name;
                mTypeTextBox.Text = "Folder";
                mLocationTextBox.Text = (directoryInfo.Parent != null) ? directoryInfo.Parent.FullName : null;
                mSizeTextBox.Text = FileSystem.FileSizeStr(FileSystem.GetDirectorySize(filePath));
                mModifiedTimeTextBox.Text = directoryInfo.LastWriteTime.ToString("dd.mm.yyyy HH:mm");
            }
            else
            {
                FileInfo fileInfo = new FileInfo(filePath);

                mNameTextBox.Text = fileInfo.Name;
                mTypeTextBox.Text = fileInfo.Extension;
                mLocationTextBox.Text = (fileInfo.DirectoryName != null) ? fileInfo.DirectoryName : null;
                mSizeTextBox.Text = FileSystem.FileSizeStr(fileInfo.Length);
                mModifiedTimeTextBox.Text = fileInfo.LastWriteTime.ToString("dd.mm.yyyy HH:mm");
            }
        }


        private void OkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}