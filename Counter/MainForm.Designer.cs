namespace Counter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Resources = new System.Windows.Forms.Button();
            this.Craftables = new System.Windows.Forms.Button();
            this.ProfilesSelector = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderText = new System.Windows.Forms.Label();
            this.UCHolder = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resourcesUC1 = new Counter.ResourcesUC();
            this.profilesUC1 = new Counter.ProfilesUC();
            this.optionsUC1 = new Counter.OptionsUC();
            this.recipesUC1 = new Counter.RecipesUC();
            this.panel1.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.UCHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Resources);
            this.panel1.Controls.Add(this.Craftables);
            this.panel1.Controls.Add(this.ProfilesSelector);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.CloseApplication);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(903, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 613);
            this.panel1.TabIndex = 0;
            // 
            // Resources
            // 
            this.Resources.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Resources.Location = new System.Drawing.Point(0, 405);
            this.Resources.Name = "Resources";
            this.Resources.Size = new System.Drawing.Size(52, 52);
            this.Resources.TabIndex = 4;
            this.Resources.Text = "R";
            this.Resources.UseVisualStyleBackColor = true;
            this.Resources.Click += new System.EventHandler(this.Resources_Click);
            // 
            // Craftables
            // 
            this.Craftables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Craftables.Location = new System.Drawing.Point(0, 457);
            this.Craftables.Name = "Craftables";
            this.Craftables.Size = new System.Drawing.Size(52, 52);
            this.Craftables.TabIndex = 3;
            this.Craftables.Text = "C";
            this.Craftables.UseVisualStyleBackColor = true;
            this.Craftables.Click += new System.EventHandler(this.Craftables_Click);
            // 
            // ProfilesSelector
            // 
            this.ProfilesSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProfilesSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProfilesSelector.Location = new System.Drawing.Point(0, 509);
            this.ProfilesSelector.Name = "ProfilesSelector";
            this.ProfilesSelector.Size = new System.Drawing.Size(52, 52);
            this.ProfilesSelector.TabIndex = 2;
            this.ProfilesSelector.Text = "P";
            this.ProfilesSelector.UseVisualStyleBackColor = true;
            this.ProfilesSelector.Click += new System.EventHandler(this.ProfilesSelector_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.Location = new System.Drawing.Point(0, 561);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(52, 52);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "O";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // CloseApplication
            // 
            this.CloseApplication.BackColor = System.Drawing.Color.Transparent;
            this.CloseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseApplication.Location = new System.Drawing.Point(0, 0);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(52, 52);
            this.CloseApplication.TabIndex = 0;
            this.CloseApplication.Text = "X";
            this.CloseApplication.UseVisualStyleBackColor = false;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.HeaderPanel.Controls.Add(this.HeaderText);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(903, 52);
            this.HeaderPanel.TabIndex = 1;
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderText.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(0, 0);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(527, 47);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Resource Counter by Fixer33";
            this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCHolder
            // 
            this.UCHolder.Controls.Add(this.recipesUC1);
            this.UCHolder.Controls.Add(this.resourcesUC1);
            this.UCHolder.Controls.Add(this.profilesUC1);
            this.UCHolder.Controls.Add(this.optionsUC1);
            this.UCHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCHolder.Location = new System.Drawing.Point(0, 52);
            this.UCHolder.Name = "UCHolder";
            this.UCHolder.Size = new System.Drawing.Size(903, 561);
            this.UCHolder.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resourcesUC1
            // 
            this.resourcesUC1.Location = new System.Drawing.Point(0, 0);
            this.resourcesUC1.Name = "resourcesUC1";
            this.resourcesUC1.Size = new System.Drawing.Size(903, 561);
            this.resourcesUC1.TabIndex = 2;
            // 
            // profilesUC1
            // 
            this.profilesUC1.Location = new System.Drawing.Point(0, 0);
            this.profilesUC1.Name = "profilesUC1";
            this.profilesUC1.Size = new System.Drawing.Size(903, 561);
            this.profilesUC1.TabIndex = 1;
            // 
            // optionsUC1
            // 
            this.optionsUC1.Location = new System.Drawing.Point(0, 0);
            this.optionsUC1.Name = "optionsUC1";
            this.optionsUC1.Size = new System.Drawing.Size(903, 561);
            this.optionsUC1.TabIndex = 0;
            // 
            // recipesUC1
            // 
            this.recipesUC1.Location = new System.Drawing.Point(0, 0);
            this.recipesUC1.Name = "recipesUC1";
            this.recipesUC1.Size = new System.Drawing.Size(903, 561);
            this.recipesUC1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 613);
            this.Controls.Add(this.UCHolder);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.UCHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Button ProfilesSelector;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button Resources;
        private System.Windows.Forms.Button Craftables;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.Panel UCHolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private OptionsUC optionsUC1;
        private ProfilesUC profilesUC1;
        private ResourcesUC resourcesUC1;
        private RecipesUC recipesUC1;
    }
}