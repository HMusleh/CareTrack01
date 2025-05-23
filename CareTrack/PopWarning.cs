﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareTrack
{
    public partial class PopWarning : Form
    {
        public PopWarning(string message)
        {
            InitializeComponent();
            PopWarningTextBox.Text = message;
            this.StartPosition = FormStartPosition.CenterParent;
            this.KeyPreview = true;
            this.ActiveControl = BtnContinueWarning;
            this.KeyDown += PopWarning_KeyDown;

        }

        private void BtnContinueWarning_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void PopWarning_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnContinueWarning.PerformClick();
            }
        }

        private void BtnCancelWarning_Click(object sender, EventArgs e)
        {
            this .DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
