using System;
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
    public partial class PopSuccessForm : Form
    {
        public PopSuccessForm(string message)
        {
            InitializeComponent();
            PopSuccessTextBox.Text = message;
            
            this.ActiveControl = BtnContinue;
            this.KeyPreview = true;
            this.KeyDown += PopSuccessForm_KeyDown;
        }
        private void PopSuccessForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnContinue.PerformClick();
            }
        }


        private void BtnContinue_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
