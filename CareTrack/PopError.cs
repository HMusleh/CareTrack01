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
    public partial class PopErrorForm : Form
    {
        public PopErrorForm(string message)
        {
            InitializeComponent();
            PopErrorTextBox.Text = message;
            this.StartPosition = FormStartPosition.CenterParent;
            this.KeyPreview = true;
            this.ActiveControl = BtnOK;
            this.KeyDown += PopErrorForm_KeyDown;

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PopErrorForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnOK.PerformClick();
            }
        }
    }
}
