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
            btnContinue = new Button();
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
            PopSuccessTextBox.BorderStyle = BorderStyle.None;
            PopSuccessTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PopSuccessTextBox.Location = new Point(181, 119);
            PopSuccessTextBox.Name = "PopSuccessTextBox";
            PopSuccessTextBox.Size = new Size(254, 96);
            PopSuccessTextBox.TabIndex = 1;
            PopSuccessTextBox.Text = "";
            PopSuccessTextBox.TextChanged += richTextBox1_TextChanged;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.LightCoral;
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(181, 267);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(254, 35);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // PopSuccessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 339);
            Controls.Add(btnContinue);
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
        private Button btnContinue;
    }
}