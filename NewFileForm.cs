using System;
using System.IO;
using System.Windows.Forms;


namespace FileExplorer
{
    public partial class NewFileForm : Form
    {
        private readonly string mCurrentPath;

        public NewFileForm(string currentPath)
        {
            this.mCurrentPath = currentPath;
            InitializeComponent();
        }


        private void OkBtn_Click(object sender, EventArgs e)
        {
            string newFileName = mFileNameInput.Text;
            string newFilePath = Path.Combine(mCurrentPath, newFileName);

            if (!FileSystem.IsValidFileName(newFileName))
            {
                MessageBox.Show("The file name can't contain any of the following characters:\n" + "\t\\/:*?\"<>|",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(newFilePath))
            {
                MessageBox.Show("A file with the same name exists!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                File.Create(newFilePath);
                Close();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
