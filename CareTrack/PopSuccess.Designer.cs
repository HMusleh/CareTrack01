namespace CareTrack
{
    partial class PopSuccessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopSuccessForm));
            pictureBox1 = new PictureBox();
            PopSuccessTextBox = new RichTextBox();
            BtnContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PopSuccessTextBox
            // 
            PopSuccessTextBox.BackColor = Color.White;
            PopSuccessTextBox.BorderStyle = BorderStyle.None;
            PopSuccessTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PopSuccessTextBox.Location = new Point(181, 165);
            PopSuccessTextBox.Name = "PopSuccessTextBox";
            PopSuccessTextBox.ReadOnly = true;
            PopSuccessTextBox.Size = new Size(423, 96);
            PopSuccessTextBox.TabIndex = 1;
            PopSuccessTextBox.Text = "";
            // 
            // BtnContinue
            // 
            BtnContinue.BackColor = Color.LightCoral;
            BtnContinue.DialogResult = DialogResult.OK;
            BtnContinue.FlatAppearance.BorderSize = 0;
            BtnContinue.FlatStyle = FlatStyle.Flat;
            BtnContinue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnContinue.Location = new Point(181, 267);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.Size = new Size(254, 35);
            BtnContinue.TabIndex = 2;
            BtnContinue.Text = "Continue";
            BtnContinue.UseVisualStyleBackColor = false;
            BtnContinue.Click += BtnContinue_Click;
            // 
            // PopSuccessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 339);
            Controls.Add(BtnContinue);
            Controls.Add(PopSuccessTextBox);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(632, 378);
            MinimumSize = new Size(632, 378);
            Name = "PopSuccessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Success!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox PopSuccessTextBox;
        private Button BtnContinue;
    }
}