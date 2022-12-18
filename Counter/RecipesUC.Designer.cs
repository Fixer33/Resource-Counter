namespace Counter
{
    partial class RecipesUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteResource = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddComponentButton = new System.Windows.Forms.Button();
            this.ComponentEnterBox = new System.Windows.Forms.TextBox();
            this.HeaderText = new System.Windows.Forms.Label();
            this.ComponentListBox = new System.Windows.Forms.ListBox();
            this.ShowRecipesToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecipeNameBox = new System.Windows.Forms.TextBox();
            this.RecipeSelectBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedRecipeName = new System.Windows.Forms.TextBox();
            this.CreateRecipeButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ConfirmNameButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MBConfirmDeleteText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResourceName,
            this.ResourceAmount,
            this.DeleteResource});
            this.dataGridView1.Location = new System.Drawing.Point(28, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(511, 463);
            this.dataGridView1.TabIndex = 9;
            // 
            // ResourceName
            // 
            this.ResourceName.HeaderText = "Resource";
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.ReadOnly = true;
            this.ResourceName.Width = 305;
            // 
            // ResourceAmount
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.ResourceAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.ResourceAmount.HeaderText = "Amount";
            this.ResourceAmount.Name = "ResourceAmount";
            this.ResourceAmount.Width = 128;
            // 
            // DeleteResource
            // 
            this.DeleteResource.HeaderText = "Delete";
            this.DeleteResource.Name = "DeleteResource";
            this.DeleteResource.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteResource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteResource.Width = 76;
            // 
            // AddComponentButton
            // 
            this.AddComponentButton.Font = new System.Drawing.Font("Aldrich", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddComponentButton.Location = new System.Drawing.Point(565, 496);
            this.AddComponentButton.Name = "AddComponentButton";
            this.AddComponentButton.Size = new System.Drawing.Size(309, 44);
            this.AddComponentButton.TabIndex = 8;
            this.AddComponentButton.Text = "Add component";
            this.AddComponentButton.UseVisualStyleBackColor = true;
            // 
            // ComponentEnterBox
            // 
            this.ComponentEnterBox.Font = new System.Drawing.Font("Aldrich", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComponentEnterBox.Location = new System.Drawing.Point(565, 363);
            this.ComponentEnterBox.Name = "ComponentEnterBox";
            this.ComponentEnterBox.Size = new System.Drawing.Size(309, 27);
            this.ComponentEnterBox.TabIndex = 7;
            this.ComponentEnterBox.TextChanged += new System.EventHandler(this.ComponentEnterBox_TextChanged);
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Aldrich", 24F, System.Drawing.FontStyle.Bold);
            this.HeaderText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HeaderText.Location = new System.Drawing.Point(379, 21);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(151, 40);
            this.HeaderText.TabIndex = 6;
            this.HeaderText.Text = "Recipes";
            // 
            // ComponentListBox
            // 
            this.ComponentListBox.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComponentListBox.FormattingEnabled = true;
            this.ComponentListBox.ItemHeight = 16;
            this.ComponentListBox.Location = new System.Drawing.Point(565, 396);
            this.ComponentListBox.Name = "ComponentListBox";
            this.ComponentListBox.Size = new System.Drawing.Size(309, 68);
            this.ComponentListBox.TabIndex = 10;
            // 
            // ShowRecipesToggle
            // 
            this.ShowRecipesToggle.AutoSize = true;
            this.ShowRecipesToggle.Location = new System.Drawing.Point(565, 470);
            this.ShowRecipesToggle.Name = "ShowRecipesToggle";
            this.ShowRecipesToggle.Size = new System.Drawing.Size(116, 17);
            this.ShowRecipesToggle.TabIndex = 11;
            this.ShowRecipesToggle.Text = "Show recipes in list";
            this.ShowRecipesToggle.UseVisualStyleBackColor = true;
            this.ShowRecipesToggle.CheckedChanged += new System.EventHandler(this.ShowRecipesToggle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aldrich", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "2. Choose component";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Aldrich", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "1. Choose recipe";
            // 
            // RecipeNameBox
            // 
            this.RecipeNameBox.Font = new System.Drawing.Font("Aldrich", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeNameBox.Location = new System.Drawing.Point(565, 232);
            this.RecipeNameBox.Name = "RecipeNameBox";
            this.RecipeNameBox.Size = new System.Drawing.Size(309, 27);
            this.RecipeNameBox.TabIndex = 12;
            this.RecipeNameBox.TextChanged += new System.EventHandler(this.RecipeNameBox_TextChanged);
            // 
            // RecipeSelectBox
            // 
            this.RecipeSelectBox.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeSelectBox.FormattingEnabled = true;
            this.RecipeSelectBox.ItemHeight = 16;
            this.RecipeSelectBox.Location = new System.Drawing.Point(565, 265);
            this.RecipeSelectBox.Name = "RecipeSelectBox";
            this.RecipeSelectBox.Size = new System.Drawing.Size(309, 68);
            this.RecipeSelectBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Aldrich", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(561, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Selected recipe";
            // 
            // SelectedRecipeName
            // 
            this.SelectedRecipeName.Enabled = false;
            this.SelectedRecipeName.Font = new System.Drawing.Font("Aldrich", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRecipeName.Location = new System.Drawing.Point(565, 104);
            this.SelectedRecipeName.Name = "SelectedRecipeName";
            this.SelectedRecipeName.Size = new System.Drawing.Size(309, 27);
            this.SelectedRecipeName.TabIndex = 17;
            // 
            // CreateRecipeButton
            // 
            this.CreateRecipeButton.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRecipeButton.Location = new System.Drawing.Point(565, 137);
            this.CreateRecipeButton.Name = "CreateRecipeButton";
            this.CreateRecipeButton.Size = new System.Drawing.Size(154, 30);
            this.CreateRecipeButton.TabIndex = 18;
            this.CreateRecipeButton.Text = "Create new";
            this.CreateRecipeButton.UseVisualStyleBackColor = true;
            this.CreateRecipeButton.Click += new System.EventHandler(this.CreateRecipeButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameButton.Location = new System.Drawing.Point(720, 137);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(154, 30);
            this.RenameButton.TabIndex = 19;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(565, 172);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(154, 30);
            this.CalculateButton.TabIndex = 20;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(720, 172);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(154, 30);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ConfirmNameButton
            // 
            this.ConfirmNameButton.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNameButton.Location = new System.Drawing.Point(565, 137);
            this.ConfirmNameButton.Name = "ConfirmNameButton";
            this.ConfirmNameButton.Size = new System.Drawing.Size(154, 30);
            this.ConfirmNameButton.TabIndex = 22;
            this.ConfirmNameButton.Text = "Confirm";
            this.ConfirmNameButton.UseVisualStyleBackColor = true;
            this.ConfirmNameButton.Visible = false;
            this.ConfirmNameButton.Click += new System.EventHandler(this.ConfirmNameButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Aldrich", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(720, 137);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(154, 30);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MBConfirmDeleteText
            // 
            this.MBConfirmDeleteText.AutoSize = true;
            this.MBConfirmDeleteText.BackColor = System.Drawing.Color.Transparent;
            this.MBConfirmDeleteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MBConfirmDeleteText.ForeColor = System.Drawing.Color.Transparent;
            this.MBConfirmDeleteText.Location = new System.Drawing.Point(13, 4);
            this.MBConfirmDeleteText.Name = "MBConfirmDeleteText";
            this.MBConfirmDeleteText.Size = new System.Drawing.Size(47, 2);
            this.MBConfirmDeleteText.TabIndex = 24;
            this.MBConfirmDeleteText.Text = "Are you sure you want to delete selected recipe?";
            // 
            // RecipesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MBConfirmDeleteText);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmNameButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.CreateRecipeButton);
            this.Controls.Add(this.SelectedRecipeName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecipeSelectBox);
            this.Controls.Add(this.RecipeNameBox);
            this.Controls.Add(this.ShowRecipesToggle);
            this.Controls.Add(this.ComponentListBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddComponentButton);
            this.Controls.Add(this.ComponentEnterBox);
            this.Controls.Add(this.HeaderText);
            this.Name = "RecipesUC";
            this.Size = new System.Drawing.Size(903, 561);
            this.Load += new System.EventHandler(this.RecipesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceAmount;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteResource;
        private System.Windows.Forms.Button AddComponentButton;
        private System.Windows.Forms.TextBox ComponentEnterBox;
        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox ComponentListBox;
        private System.Windows.Forms.CheckBox ShowRecipesToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RecipeNameBox;
        private System.Windows.Forms.ListBox RecipeSelectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SelectedRecipeName;
        private System.Windows.Forms.Button CreateRecipeButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ConfirmNameButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label MBConfirmDeleteText;
    }
}
