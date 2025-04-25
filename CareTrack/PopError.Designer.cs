namespace CareTrack
{
    partial class PopErrorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopErrorForm));
            PopErrorTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            BtnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PopErrorTextBox
            // 
            PopErrorTextBox.BackColor = Color.White;
            PopErrorTextBox.BorderStyle = BorderStyle.None;
            PopErrorTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PopErrorTextBox.Location = new Point(181, 160);
            PopErrorTextBox.Name = "PopErrorTextBox";
            PopErrorTextBox.ReadOnly = true;
            PopErrorTextBox.Size = new Size(423, 100);
            PopErrorTextBox.TabIndex = 8;
            PopErrorTextBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.LightCoral;
            BtnOK.DialogResult = DialogResult.OK;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnOK.Location = new Point(181, 266);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(254, 35);
            BtnOK.TabIndex = 9;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = false;
            BtnOK.Click += BtnOK_Click;
            // 
            // PopErrorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 339);
            Controls.Add(BtnOK);
            Controls.Add(PopErrorTextBox);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(632, 378);
            MinimumSize = new Size(632, 378);
            Name = "PopErrorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox PopErrorTextBox;
        private PictureBox pictureBox1;
        private Button BtnOK;
    }
}