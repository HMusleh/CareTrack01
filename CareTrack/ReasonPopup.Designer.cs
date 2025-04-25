namespace CareTrack
{
    partial class ReasonPopup : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            radioClientRefused = new RadioButton();
            radioNoTasks = new RadioButton();
            radioCMRequested = new RadioButton();
            BtnContinue = new Button();
            groupBoxReasons = new GroupBox();
            groupBoxReasons.SuspendLayout();
            SuspendLayout();
            // 
            // radioClientRefused
            // 
            radioClientRefused.AutoSize = true;
            radioClientRefused.Location = new Point(10, 30);
            radioClientRefused.Name = "radioClientRefused";
            radioClientRefused.Size = new Size(338, 25);
            radioClientRefused.TabIndex = 0;
            radioClientRefused.Text = "The client refused to complete the tasks";
            // 
            // radioNoTasks
            // 
            radioNoTasks.AutoSize = true;
            radioNoTasks.Location = new Point(10, 60);
            radioNoTasks.Name = "radioNoTasks";
            radioNoTasks.Size = new Size(314, 25);
            radioNoTasks.TabIndex = 1;
            radioNoTasks.Text = "There are no tasks assigned for today";
            // 
            // radioCaseManager
            // 
            radioCMRequested.AutoSize = true;
            radioCMRequested.Location = new Point(10, 90);
            radioCMRequested.Name = "radioCaseManager";
            radioCMRequested.Size = new Size(440, 25);
            radioCMRequested.TabIndex = 2;
            radioCMRequested.Text = "The case manager requested no tasks be completed";
            // 
            // btnContinue
            // 
            BtnContinue.BackColor = Color.LightCoral;
            BtnContinue.FlatAppearance.BorderSize = 0;
            BtnContinue.FlatStyle = FlatStyle.Flat;
            BtnContinue.Font = new Font("Century Gothic", 12F);
            BtnContinue.Location = new Point(175, 245);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.Size = new Size(254, 35);
            BtnContinue.TabIndex = 1;
            BtnContinue.Text = "Continue";
            BtnContinue.UseVisualStyleBackColor = false;
            BtnContinue.Click += BtnContinue_Click;
            // 
            // groupBoxReasons
            // 
            groupBoxReasons.Controls.Add(radioClientRefused);
            groupBoxReasons.Controls.Add(radioNoTasks);
            groupBoxReasons.Controls.Add(radioCMRequested);
            groupBoxReasons.Font = new Font("Century Gothic", 12F);
            groupBoxReasons.Location = new Point(90, 54);
            groupBoxReasons.Name = "groupBoxReasons";
            groupBoxReasons.Size = new Size(417, 155);
            groupBoxReasons.TabIndex = 0;
            groupBoxReasons.TabStop = false;
            groupBoxReasons.Text = "Please select the reason:";
            // 
            // ReasonPopup
            // 
            
            

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 339);
            Controls.Add(groupBoxReasons);
            Controls.Add(BtnContinue);
            MaximumSize = new Size(632, 378);
            MinimumSize = new Size(632, 378);
            Name = "ReasonPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reason";
            groupBoxReasons.ResumeLayout(false);
            groupBoxReasons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioClientRefused;
        private RadioButton radioNoTasks;
        private RadioButton radioCMRequested;
        private Button BtnContinue;
        private GroupBox groupBoxReasons;
       
    }
}
