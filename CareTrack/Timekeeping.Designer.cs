namespace CareTrack
{
    partial class Timekeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timekeeping));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            panelMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            button9 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(828, 135);
            label1.Name = "label1";
            label1.Size = new Size(257, 33);
            label1.TabIndex = 0;
            label1.Text = "Shift starts at: 00:00";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(828, 352);
            label2.Name = "label2";
            label2.Size = new Size(254, 33);
            label2.TabIndex = 1;
            label2.Text = "Shift ends at: 00:00";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(663, 171);
            button1.Name = "button1";
            button1.Size = new Size(561, 94);
            button1.TabIndex = 2;
            button1.Text = "Clock In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(663, 388);
            button2.Name = "button2";
            button2.Size = new Size(561, 94);
            button2.TabIndex = 7;
            button2.Text = "Clock Out";
            button2.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightCoral;
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button8);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(1237, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(268, 737);
            panelMenu.TabIndex = 8;
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
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 18F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 122);
            button3.Name = "button3";
            button3.Size = new Size(265, 81);
            button3.TabIndex = 6;
            button3.Tag = "Home";
            button3.Text = "          Home";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
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
            // 
            // Timekeeping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1505, 737);
            Controls.Add(panelMenu);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Timekeeping";
            Text = "CT - Time Punch";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel panelMenu;
        private Panel panel1;
        private Button button9;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}