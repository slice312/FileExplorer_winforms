namespace FileExplorer
{
    partial class PropertiesForm
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
            this.mNameLabel = new System.Windows.Forms.Label();
            this.mTypeLabel = new System.Windows.Forms.Label();
            this.mLocationLabel = new System.Windows.Forms.Label();
            this.mSizeLabel = new System.Windows.Forms.Label();
            this.mModifiedTimeLabel = new System.Windows.Forms.Label();
            this.mNameTextBox = new System.Windows.Forms.TextBox();
            this.mModifiedTimeTextBox = new System.Windows.Forms.TextBox();
            this.mSizeTextBox = new System.Windows.Forms.TextBox();
            this.mLocationTextBox = new System.Windows.Forms.TextBox();
            this.mTypeTextBox = new System.Windows.Forms.TextBox();
            this.mOkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mNameLabel
            // 
            this.mNameLabel.Location = new System.Drawing.Point(12, 35);
            this.mNameLabel.Name = "mNameLabel";
            this.mNameLabel.Size = new System.Drawing.Size(100, 22);
            this.mNameLabel.TabIndex = 10;
            this.mNameLabel.Text = "Name";
            // 
            // mTypeLabel
            // 
            this.mTypeLabel.Location = new System.Drawing.Point(12, 63);
            this.mTypeLabel.Name = "mTypeLabel";
            this.mTypeLabel.Size = new System.Drawing.Size(100, 22);
            this.mTypeLabel.TabIndex = 9;
            this.mTypeLabel.Text = "Type";
            // 
            // mLocationLabel
            // 
            this.mLocationLabel.Location = new System.Drawing.Point(12, 91);
            this.mLocationLabel.Name = "mLocationLabel";
            this.mLocationLabel.Size = new System.Drawing.Size(100, 22);
            this.mLocationLabel.TabIndex = 8;
            this.mLocationLabel.Text = "Location";
            // 
            // mSizeLabel
            // 
            this.mSizeLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mSizeLabel.Location = new System.Drawing.Point(12, 119);
            this.mSizeLabel.Name = "mSizeLabel";
            this.mSizeLabel.Size = new System.Drawing.Size(100, 22);
            this.mSizeLabel.TabIndex = 7;
            this.mSizeLabel.Text = "Size";
            // 
            // mModifiedTimeLabel
            // 
            this.mModifiedTimeLabel.Location = new System.Drawing.Point(12, 147);
            this.mModifiedTimeLabel.Name = "mModifiedTimeLabel";
            this.mModifiedTimeLabel.Size = new System.Drawing.Size(100, 22);
            this.mModifiedTimeLabel.TabIndex = 6;
            this.mModifiedTimeLabel.Text = "Last modified";
            // 
            // mNameTextBox
            // 
            this.mNameTextBox.Location = new System.Drawing.Point(131, 32);
            this.mNameTextBox.Name = "mNameTextBox";
            this.mNameTextBox.ReadOnly = true;
            this.mNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.mNameTextBox.TabIndex = 5;
            // 
            // mModifiedTimeTextBox
            // 
            this.mModifiedTimeTextBox.Location = new System.Drawing.Point(131, 144);
            this.mModifiedTimeTextBox.Name = "mModifiedTimeTextBox";
            this.mModifiedTimeTextBox.ReadOnly = true;
            this.mModifiedTimeTextBox.Size = new System.Drawing.Size(166, 22);
            this.mModifiedTimeTextBox.TabIndex = 4;
            // 
            // mSizeTextBox
            // 
            this.mSizeTextBox.Location = new System.Drawing.Point(131, 116);
            this.mSizeTextBox.Name = "mSizeTextBox";
            this.mSizeTextBox.ReadOnly = true;
            this.mSizeTextBox.Size = new System.Drawing.Size(166, 22);
            this.mSizeTextBox.TabIndex = 3;
            // 
            // mLocationTextBox
            // 
            this.mLocationTextBox.Location = new System.Drawing.Point(131, 88);
            this.mLocationTextBox.Name = "mLocationTextBox";
            this.mLocationTextBox.ReadOnly = true;
            this.mLocationTextBox.Size = new System.Drawing.Size(166, 22);
            this.mLocationTextBox.TabIndex = 2;
            // 
            // mTypeTextBox
            // 
            this.mTypeTextBox.Location = new System.Drawing.Point(131, 60);
            this.mTypeTextBox.Name = "mTypeTextBox";
            this.mTypeTextBox.ReadOnly = true;
            this.mTypeTextBox.Size = new System.Drawing.Size(166, 22);
            this.mTypeTextBox.TabIndex = 1;
            // 
            // mOkBtn
            // 
            this.mOkBtn.Location = new System.Drawing.Point(131, 186);
            this.mOkBtn.Name = "mOkBtn";
            this.mOkBtn.Size = new System.Drawing.Size(87, 25);
            this.mOkBtn.TabIndex = 0;
            this.mOkBtn.Text = "OK";
            this.mOkBtn.UseVisualStyleBackColor = true;
            this.mOkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 242);
            this.Controls.Add(this.mOkBtn);
            this.Controls.Add(this.mTypeTextBox);
            this.Controls.Add(this.mLocationTextBox);
            this.Controls.Add(this.mSizeTextBox);
            this.Controls.Add(this.mModifiedTimeTextBox);
            this.Controls.Add(this.mNameTextBox);
            this.Controls.Add(this.mModifiedTimeLabel);
            this.Controls.Add(this.mSizeLabel);
            this.Controls.Add(this.mLocationLabel);
            this.Controls.Add(this.mTypeLabel);
            this.Controls.Add(this.mNameLabel);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mNameLabel;
        private System.Windows.Forms.Label mTypeLabel;
        private System.Windows.Forms.Label mLocationLabel;
        private System.Windows.Forms.Label mSizeLabel;
        private System.Windows.Forms.Label mModifiedTimeLabel;
        private System.Windows.Forms.TextBox mNameTextBox;
        private System.Windows.Forms.TextBox mModifiedTimeTextBox;
        private System.Windows.Forms.TextBox mSizeTextBox;
        private System.Windows.Forms.TextBox mLocationTextBox;
        private System.Windows.Forms.TextBox mTypeTextBox;
        private System.Windows.Forms.Button mOkBtn;
    }
}