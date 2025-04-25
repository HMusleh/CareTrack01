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
    public partial class ReasonPopup : Form
    {
        public string SelectedReason { get; private set; } = "";
        public ReasonPopup()
        {
            InitializeComponent();
            radioClientRefused.Checked = true;
            SelectedReason = radioClientRefused.Text;
            radioClientRefused.CheckedChanged += RadioChanged;
            radioNoTasks.CheckedChanged += RadioChanged;
            radioCMRequested.CheckedChanged += RadioChanged;

            this.KeyPreview = true;
            this.KeyDown += ReasonPopup_KeyDown;
            this.ActiveControl = BtnContinue;

        }
        private void RadioChanged(object? sender, EventArgs e)
        {
            if (radioClientRefused.Checked)
                SelectedReason = radioClientRefused.Text;
            else if (radioNoTasks.Checked)
                SelectedReason = radioNoTasks.Text;
            else if (radioCMRequested.Checked)
                SelectedReason = radioCMRequested.Text;
        }


        private void BtnContinue_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        private void ReasonPopup_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnContinue.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
