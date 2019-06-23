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
                nameTextBox.Text = directoryInfo.Name;
                pictureBox.Image = ShellIcon.FolderIcon.ToBitmap();
                typeLabel.Text = "File folder";
                locationLabel.Text = directoryInfo.Parent?.FullName.WithoutLongPathPrefix();
                sizeLabel.Text = FileSystem.FileSizeStr(FileSystem.GetDirectorySize(filePath));
                createdTimeLabel.Text = directoryInfo.CreationTime.ToString("dd.MM.yyyy HH:mm");
                modifiedTimeLabel.Text = directoryInfo.LastWriteTime.ToString("dd.MM.yyyy HH:mm");

                hiddenCheckBox.Checked = directoryInfo.Attributes.HasFlag(FileAttributes.Hidden);
                readonlyCheckBox.Checked = directoryInfo.Attributes.HasFlag(FileAttributes.ReadOnly);
            }
            else
            {
                FileInfo fileInfo = new FileInfo(filePath);
                nameTextBox.Text = fileInfo.Name;
                pictureBox.Image = ShellIcon.GetLargeIcon(filePath.WithoutLongPathPrefix()).ToBitmap();
                typeLabel.Text = "File folder";
                locationLabel.Text = fileInfo.DirectoryName?.WithoutLongPathPrefix();
                sizeLabel.Text = FileSystem.FileSizeStr(fileInfo.Length);
                createdTimeLabel.Text = fileInfo.CreationTime.ToString("dd.MM.yyyy HH:mm");
                modifiedTimeLabel.Text = fileInfo.LastWriteTime.ToString("dd.MM.yyyy HH:mm");

                hiddenCheckBox.Checked = fileInfo.Attributes.HasFlag(FileAttributes.Hidden);
                readonlyCheckBox.Checked = fileInfo.Attributes.HasFlag(FileAttributes.ReadOnly);
            }
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}