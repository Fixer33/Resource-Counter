namespace Counter
{
    partial class ResourcesUC
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddResource = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResourceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteResource = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Aldrich", 24F, System.Drawing.FontStyle.Bold);
            this.HeaderText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HeaderText.Location = new System.Drawing.Point(332, 21);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(198, 40);
            this.HeaderText.TabIndex = 1;
            this.HeaderText.Text = "Resources";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Aldrich", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(556, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 27);
            this.textBox1.TabIndex = 3;
            // 
            // AddResource
            // 
            this.AddResource.Font = new System.Drawing.Font("Aldrich", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResource.Location = new System.Drawing.Point(556, 110);
            this.AddResource.Name = "AddResource";
            this.AddResource.Size = new System.Drawing.Size(309, 44);
            this.AddResource.TabIndex = 4;
            this.AddResource.Text = "Add resource";
            this.AddResource.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(511, 463);
            this.dataGridView1.TabIndex = 5;
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
            // ResourcesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddResource);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HeaderText);
            this.Name = "ResourcesUC";
            this.Size = new System.Drawing.Size(903, 561);
            this.Load += new System.EventHandler(this.ResourcesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddResource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResourceAmount;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteResource;
    }
}
