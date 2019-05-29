namespace FileExplorer
{
    partial class NewFileForm
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
            this.mLabel1 = new System.Windows.Forms.Label();
            this.mFileNameInput = new System.Windows.Forms.TextBox();
            this.mOkBtn = new System.Windows.Forms.Button();
            this.mCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mLabel1
            // 
            this.mLabel1.AutoSize = true;
            this.mLabel1.Location = new System.Drawing.Point(24, 45);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(70, 14);
            this.mLabel1.TabIndex = 0;
            this.mLabel1.Text = "File name";
            // 
            // mFileNameInput
            // 
            this.mFileNameInput.Location = new System.Drawing.Point(107, 43);
            this.mFileNameInput.Name = "mFileNameInput";
            this.mFileNameInput.Size = new System.Drawing.Size(359, 22);
            this.mFileNameInput.TabIndex = 1;
            // 
            // mOkBtn
            // 
            this.mOkBtn.Location = new System.Drawing.Point(397, 82);
            this.mOkBtn.Name = "mOkBtn";
            this.mOkBtn.Size = new System.Drawing.Size(69, 25);
            this.mOkBtn.TabIndex = 2;
            this.mOkBtn.Text = "OK";
            this.mOkBtn.UseVisualStyleBackColor = true;
            this.mOkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // mCancelBtn
            // 
            this.mCancelBtn.Location = new System.Drawing.Point(308, 82);
            this.mCancelBtn.Name = "mCancelBtn";
            this.mCancelBtn.Size = new System.Drawing.Size(73, 25);
            this.mCancelBtn.TabIndex = 3;
            this.mCancelBtn.Text = "Cancel";
            this.mCancelBtn.UseVisualStyleBackColor = true;
            this.mCancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // NewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 128);
            this.ControlBox = false;
            this.Controls.Add(this.mCancelBtn);
            this.Controls.Add(this.mOkBtn);
            this.Controls.Add(this.mFileNameInput);
            this.Controls.Add(this.mLabel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewFileForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mLabel1;
        private System.Windows.Forms.TextBox mFileNameInput;
        private System.Windows.Forms.Button mOkBtn;
        private System.Windows.Forms.Button mCancelBtn;
    }
}