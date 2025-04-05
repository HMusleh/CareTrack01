
namespace CareTrack
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            button2 = new Button();
            button3 = new Button();
            panelMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button1 = new Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(663, 264);
            button2.Name = "button2";
            button2.Size = new Size(520, 138);
            button2.TabIndex = 3;
            button2.Text = "View Tasks";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(663, 470);
            button3.Name = "button3";
            button3.Size = new Size(520, 138);
            button3.TabIndex = 4;
            button3.Text = "View Schedule";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightCoral;
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button8);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(1237, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(268, 666);
            panelMenu.TabIndex = 5;
            panelMenu.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 113);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(3, 0);
            button9.Name = "button9";
            button9.Size = new Size(262, 110);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 18F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 122);
            button4.Name = "button4";
            button4.Size = new Size(265, 81);
            button4.TabIndex = 6;
            button4.Tag = "Home";
            button4.Text = "          Home";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 18F);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 209);
            button5.Name = "button5";
            button5.Size = new Size(265, 81);
            button5.TabIndex = 7;
            button5.Tag = "Tasks";
            button5.Text = "          Tasks";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 18F);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 296);
            button6.Name = "button6";
            button6.Size = new Size(265, 81);
            button6.TabIndex = 8;
            button6.Tag = "Timekeeping";
            button6.Text = "          Timekeeping";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 18F);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 383);
            button7.Name = "button7";
            button7.Size = new Size(265, 81);
            button7.TabIndex = 9;
            button7.Tag = "Notes";
            button7.Text = "          Notes";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 18F);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(3, 470);
            button8.Name = "button8";
            button8.Size = new Size(265, 81);
            button8.TabIndex = 10;
            button8.Tag = "Logout";
            button8.Text = "          Logout";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(663, 58);
            button1.Name = "button1";
            button1.Size = new Size(520, 138);
            button1.TabIndex = 0;
            button1.Text = "Clock In/Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1505, 666);
            Controls.Add(panelMenu);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "HomePage";
            RightToLeft = RightToLeft.No;
            Text = "CT - Home";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
         
        }

        #endregion
        private Button button2;
        private Button button3;
        private FlowLayoutPanel panelMenu;
        private Panel panel1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button1;
        private Button button9;
    }
}