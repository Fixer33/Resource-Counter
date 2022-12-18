namespace Counter
{
    partial class OptionsUC
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
            this.LanguageHeaderText = new System.Windows.Forms.Label();
            this.EnglishLangChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LanguageHeaderText
            // 
            this.LanguageHeaderText.AutoSize = true;
            this.LanguageHeaderText.Font = new System.Drawing.Font("Aldrich", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageHeaderText.Location = new System.Drawing.Point(375, 26);
            this.LanguageHeaderText.Name = "LanguageHeaderText";
            this.LanguageHeaderText.Size = new System.Drawing.Size(115, 27);
            this.LanguageHeaderText.TabIndex = 0;
            this.LanguageHeaderText.Text = "Language";
            // 
            // EnglishLangChoose
            // 
            this.EnglishLangChoose.Location = new System.Drawing.Point(399, 75);
            this.EnglishLangChoose.Name = "EnglishLangChoose";
            this.EnglishLangChoose.Size = new System.Drawing.Size(62, 37);
            this.EnglishLangChoose.TabIndex = 1;
            this.EnglishLangChoose.Text = "ENG";
            this.EnglishLangChoose.UseVisualStyleBackColor = true;
            // 
            // OptionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnglishLangChoose);
            this.Controls.Add(this.LanguageHeaderText);
            this.Name = "OptionsUC";
            this.Size = new System.Drawing.Size(903, 561);
            this.Load += new System.EventHandler(this.OptionsUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LanguageHeaderText;
        private System.Windows.Forms.Button EnglishLangChoose;
    }
}
