
namespace CareTrack
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(664, 515);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Username";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.ButtonFace;
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            maskedTextBox1.ForeColor = SystemColors.WindowFrame;
            maskedTextBox1.Location = new Point(664, 569);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(176, 31);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(600, 633);
            button1.Name = "button1";
            button1.Size = new Size(304, 70);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Red;
            linkLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(844, 522);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 16);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot username?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Gray;
            linkLabel2.Location = new Point(844, 576);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(112, 16);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot password?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1505, 737);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "Login";
            Text = "Caregiver Track";
            Load += this.Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
