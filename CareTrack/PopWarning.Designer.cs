﻿namespace CareTrack
{
    partial class PopWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopWarning));
            BtnContinueWarning = new Button();
            PopWarningTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            btnCancelWarning = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnContinueWarning
            // 
            BtnContinueWarning.BackColor = Color.LightCoral;
            BtnContinueWarning.FlatAppearance.BorderSize = 0;
            BtnContinueWarning.FlatStyle = FlatStyle.Flat;
            BtnContinueWarning.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnContinueWarning.Location = new Point(30, 292);
            BtnContinueWarning.Name = "btnContinueWarning";
            BtnContinueWarning.Size = new Size(254, 35);
            BtnContinueWarning.TabIndex = 5;
            BtnContinueWarning.Text = "Continue";
            BtnContinueWarning.UseVisualStyleBackColor = false;
            BtnContinueWarning.Click += BtnContinueWarning_Click;
            // 
            // PopWarningTextBox
            // 
            PopWarningTextBox.BackColor = Color.White;
            PopWarningTextBox.BorderStyle = BorderStyle.None;
            PopWarningTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PopWarningTextBox.Location = new Point(143, 165);
            PopWarningTextBox.Name = "PopWarningTextBox";
            PopWarningTextBox.ReadOnly = true;
            PopWarningTextBox.Size = new Size(461, 96);
            PopWarningTextBox.TabIndex = 4;
            PopWarningTextBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnCancelWarning
            // 
            btnCancelWarning.BackColor = Color.LightGray;
            btnCancelWarning.FlatAppearance.BorderSize = 0;
            btnCancelWarning.FlatStyle = FlatStyle.Flat;
            btnCancelWarning.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelWarning.Location = new Point(326, 292);
            btnCancelWarning.Name = "btnCancelWarning";
            btnCancelWarning.Size = new Size(254, 35);
            btnCancelWarning.TabIndex = 6;
            btnCancelWarning.Text = "Cancel";
            btnCancelWarning.UseVisualStyleBackColor = false;
            btnCancelWarning.Click += BtnCancelWarning_Click;
            // 
            // PopWarning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(616, 339);
            Controls.Add(btnCancelWarning);
            Controls.Add(BtnContinueWarning);
            Controls.Add(PopWarningTextBox);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(632, 378);
            MinimumSize = new Size(632, 378);
            Name = "PopWarning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warning!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnContinueWarning;
        private RichTextBox PopWarningTextBox;
        private PictureBox pictureBox1;
        private Button btnCancelWarning;
    }
}