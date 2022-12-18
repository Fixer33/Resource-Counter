namespace Counter
{
    partial class ProfilesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilesUC));
            this.HeaderText = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SavedProfilesList = new System.Windows.Forms.Label();
            this.SelectedProfileHeader = new System.Windows.Forms.Label();
            this.AddNewProfileBut = new System.Windows.Forms.Button();
            this.LoadProfileBut = new System.Windows.Forms.Button();
            this.ProfileNameTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveProfileInfoBut = new System.Windows.Forms.Button();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.MBEmptyNameText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            resources.ApplyResources(this.HeaderText, "HeaderText");
            this.HeaderText.Name = "HeaderText";
            // 
            // listBox1
            // 
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SavedProfilesList
            // 
            resources.ApplyResources(this.SavedProfilesList, "SavedProfilesList");
            this.SavedProfilesList.Name = "SavedProfilesList";
            // 
            // SelectedProfileHeader
            // 
            resources.ApplyResources(this.SelectedProfileHeader, "SelectedProfileHeader");
            this.SelectedProfileHeader.Name = "SelectedProfileHeader";
            // 
            // AddNewProfileBut
            // 
            resources.ApplyResources(this.AddNewProfileBut, "AddNewProfileBut");
            this.AddNewProfileBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddNewProfileBut.Name = "AddNewProfileBut";
            this.AddNewProfileBut.UseVisualStyleBackColor = false;
            this.AddNewProfileBut.Click += new System.EventHandler(this.AddNewProfileBut_Click);
            // 
            // LoadProfileBut
            // 
            resources.ApplyResources(this.LoadProfileBut, "LoadProfileBut");
            this.LoadProfileBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoadProfileBut.Name = "LoadProfileBut";
            this.LoadProfileBut.UseVisualStyleBackColor = false;
            this.LoadProfileBut.Click += new System.EventHandler(this.LoadProfileBut_Click);
            // 
            // ProfileNameTextBox
            // 
            resources.ApplyResources(this.ProfileNameTextBox, "ProfileNameTextBox");
            this.ProfileNameTextBox.Name = "ProfileNameTextBox";
            // 
            // SaveProfileInfoBut
            // 
            resources.ApplyResources(this.SaveProfileInfoBut, "SaveProfileInfoBut");
            this.SaveProfileInfoBut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaveProfileInfoBut.Name = "SaveProfileInfoBut";
            this.SaveProfileInfoBut.UseVisualStyleBackColor = false;
            this.SaveProfileInfoBut.Click += new System.EventHandler(this.SaveProfileInfoBut_Click);
            // 
            // DeleteProfileButton
            // 
            resources.ApplyResources(this.DeleteProfileButton, "DeleteProfileButton");
            this.DeleteProfileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.UseVisualStyleBackColor = false;
            // 
            // MBEmptyNameText
            // 
            resources.ApplyResources(this.MBEmptyNameText, "MBEmptyNameText");
            this.MBEmptyNameText.BackColor = System.Drawing.Color.Transparent;
            this.MBEmptyNameText.ForeColor = System.Drawing.Color.Transparent;
            this.MBEmptyNameText.Name = "MBEmptyNameText";
            // 
            // ProfilesUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MBEmptyNameText);
            this.Controls.Add(this.DeleteProfileButton);
            this.Controls.Add(this.SaveProfileInfoBut);
            this.Controls.Add(this.ProfileNameTextBox);
            this.Controls.Add(this.LoadProfileBut);
            this.Controls.Add(this.AddNewProfileBut);
            this.Controls.Add(this.SelectedProfileHeader);
            this.Controls.Add(this.SavedProfilesList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HeaderText);
            this.Name = "ProfilesUC";
            this.Load += new System.EventHandler(this.ProfilesUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label SavedProfilesList;
        private System.Windows.Forms.Label SelectedProfileHeader;
        private System.Windows.Forms.Button AddNewProfileBut;
        private System.Windows.Forms.Button LoadProfileBut;
        private System.Windows.Forms.RichTextBox ProfileNameTextBox;
        private System.Windows.Forms.Button SaveProfileInfoBut;
        private System.Windows.Forms.Button DeleteProfileButton;
        private System.Windows.Forms.Label MBEmptyNameText;
    }
}
