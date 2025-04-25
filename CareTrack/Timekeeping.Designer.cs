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
            btnDropDownMenu = new Button();
            btnHome = new Button();
            btnTimeKeeping = new Button();
            btnSchedule = new Button();
            btnTasks = new Button();
            btnNotes = new Button();
            btnHelp = new Button();
            btnLogOut = new Button();
            button3 = new Button();
            lblClockInTime = new Label();
            lblShiftEndTime = new Label();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(717, 186);
            label1.Name = "label1";
            label1.Size = new Size(190, 33);
            label1.TabIndex = 0;
            label1.Text = "Shift starts at: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(717, 403);
            label2.Name = "label2";
            label2.Size = new Size(187, 33);
            label2.TabIndex = 1;
            label2.Text = "Shift ends at: ";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(552, 222);
            button1.Name = "button1";
            button1.Size = new Size(561, 94);
            button1.TabIndex = 2;
            button1.Text = "Clock In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(552, 439);
            button2.Name = "button2";
            button2.Size = new Size(561, 94);
            button2.TabIndex = 7;
            button2.Text = "Clock Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // panelMenu
            // 
            panelMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMenu.BackColor = Color.LightCoral;
            panelMenu.Controls.Add(btnDropDownMenu);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnTimeKeeping);
            panelMenu.Controls.Add(btnSchedule);
            panelMenu.Controls.Add(btnTasks);
            panelMenu.Controls.Add(btnNotes);
            panelMenu.Controls.Add(btnHelp);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.FlowDirection = FlowDirection.TopDown;
            panelMenu.Location = new Point(1237, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(268, 110);
            panelMenu.TabIndex = 6;
            panelMenu.WrapContents = false;
            // 
            // btnDropDownMenu
            // 
            btnDropDownMenu.FlatAppearance.BorderSize = 0;
            btnDropDownMenu.FlatStyle = FlatStyle.Flat;
            btnDropDownMenu.Image = (Image)resources.GetObject("btnDropDownMenu.Image");
            btnDropDownMenu.Location = new Point(3, 3);
            btnDropDownMenu.Name = "btnDropDownMenu";
            btnDropDownMenu.Size = new Size(262, 110);
            btnDropDownMenu.TabIndex = 0;
            btnDropDownMenu.UseVisualStyleBackColor = true;
            btnDropDownMenu.Click += BtnDropDownMenu_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 18F);
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 119);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(268, 81);
            btnHome.TabIndex = 6;
            btnHome.Tag = "Home";
            btnHome.Text = "          Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += BtnHome_Click;
            // 
            // btnTimeKeeping
            // 
            btnTimeKeeping.Dock = DockStyle.Top;
            btnTimeKeeping.FlatAppearance.BorderSize = 0;
            btnTimeKeeping.FlatStyle = FlatStyle.Flat;
            btnTimeKeeping.Font = new Font("Century Gothic", 18F);
            btnTimeKeeping.Image = (Image)resources.GetObject("btnTimeKeeping.Image");
            btnTimeKeeping.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.Location = new Point(3, 206);
            btnTimeKeeping.Name = "btnTimeKeeping";
            btnTimeKeeping.Size = new Size(268, 81);
            btnTimeKeeping.TabIndex = 8;
            btnTimeKeeping.Tag = "Timekeeping";
            btnTimeKeeping.Text = "          Timekeeping";
            btnTimeKeeping.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.UseVisualStyleBackColor = true;
            btnTimeKeeping.Click += BtnTimeKeeping_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Century Gothic", 18F);
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(3, 293);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(268, 81);
            btnSchedule.TabIndex = 13;
            btnSchedule.Tag = "Notes";
            btnSchedule.Text = "          Schedule";
            btnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedule.UseVisualStyleBackColor = true;
            btnSchedule.Click += BtnSchedule_Click;
            // 
            // btnTasks
            // 
            btnTasks.Dock = DockStyle.Top;
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Century Gothic", 18F);
            btnTasks.Image = (Image)resources.GetObject("btnTasks.Image");
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(3, 380);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(268, 81);
            btnTasks.TabIndex = 7;
            btnTasks.Tag = "Tasks";
            btnTasks.Text = "          Tasks";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += BtnTasks_Click;
            // 
            // btnNotes
            // 
            btnNotes.Dock = DockStyle.Top;
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Century Gothic", 18F);
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotes.Location = new Point(3, 467);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(268, 81);
            btnNotes.TabIndex = 9;
            btnNotes.Tag = "Notes";
            btnNotes.Text = "          Notes";
            btnNotes.TextAlign = ContentAlignment.MiddleLeft;
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += BtnNotes_Click;
            // 
            // btnHelp
            // 
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Century Gothic", 18F);
            btnHelp.Image = (Image)resources.GetObject("btnHelp.Image");
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(3, 554);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(268, 81);
            btnHelp.TabIndex = 14;
            btnHelp.Tag = "Notes";
            btnHelp.Text = "          Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += BtnHelp_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 18F);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(3, 641);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(268, 81);
            btnLogOut.TabIndex = 10;
            btnLogOut.Tag = "Logout";
            btnLogOut.Text = "          Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += BtnLogOut_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 667);
            button3.Name = "button3";
            button3.Size = new Size(178, 58);
            button3.TabIndex = 8;
            button3.Text = "Help";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // lblClockInTime
            // 
            lblClockInTime.AutoSize = true;
            lblClockInTime.Font = new Font("Century Gothic", 14F);
            lblClockInTime.Location = new Point(950, 190);
            lblClockInTime.Name = "lblClockInTime";
            lblClockInTime.Size = new Size(22, 22);
            lblClockInTime.TabIndex = 0;
            lblClockInTime.Text = "--";
            // 
            // lblShiftEndTime
            // 
            lblShiftEndTime.AutoSize = true;
            lblShiftEndTime.Font = new Font("Century Gothic", 14F);
            lblShiftEndTime.Location = new Point(950, 410);
            lblShiftEndTime.Name = "lblShiftEndTime";
            lblShiftEndTime.Size = new Size(22, 22);
            lblShiftEndTime.TabIndex = 1;
            lblShiftEndTime.Text = "--";
            // 
            // Timekeeping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1505, 737);
            Controls.Add(lblClockInTime);
            Controls.Add(lblShiftEndTime);
            Controls.Add(button3);
            Controls.Add(panelMenu);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(1521, 776);
            MinimumSize = new Size(1521, 776);
            Name = "Timekeeping";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CT - Time Punch";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel panelMenu;
        private Button btnDropDownMenu;
        private Button btnHome;
        private Button btnTasks;
        private Button btnTimeKeeping;
        private Button btnNotes;
        private Button btnLogOut;
        private Button button3;
        private Button btnSchedule;
        private Button btnHelp;
        private Label lblClockInTime;
        private Label lblShiftEndTime;

    }
}