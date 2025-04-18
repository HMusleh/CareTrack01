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
    public partial class PopWarning : Form
    {
        public PopWarning(string message)
        {
            InitializeComponent();
            PopWarningTextBox.Text = message;
        }

        private void btnContinueWarning_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelWarning_Click(object sender, EventArgs e)
        {
            this .DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
