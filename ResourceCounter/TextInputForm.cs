﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourceCounter
{
    public partial class TextInputForm : Form
    {
        public string Result = null;
        public TextInputForm()
        {
            InitializeComponent();
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Result = InputField.Text;
            this.Close();
        }

        
    }
}
