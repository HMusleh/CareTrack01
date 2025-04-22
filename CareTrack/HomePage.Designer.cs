
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
            btnViewTasks = new Button();
            btnClockInOut = new Button();
            btnViewSchedule = new Button();
            panelMenu = new FlowLayoutPanel();
            btnDropDownMenu = new Button();
            btnHome = new Button();
            btnTimeKeeping = new Button();
            btnSchedule = new Button();
            btnTasks = new Button();
            btnNotes = new Button();
            btnHelp = new Button();
            btnLogOut = new Button();
            button1 = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnViewTasks
            // 
            btnViewTasks.BackColor = Color.FromArgb(255, 128, 128);
            btnViewTasks.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewTasks.Location = new Point(563, 265);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(520, 138);
            btnViewTasks.TabIndex = 3;
            btnViewTasks.Text = "View Tasks";
            btnViewTasks.UseVisualStyleBackColor = false;
            btnViewTasks.Click += btnViewTasks_Click;
            // 
            // btnClockInOut
            // 
            btnClockInOut.AutoSize = true;
            btnClockInOut.BackColor = Color.FromArgb(255, 128, 128);
            btnClockInOut.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClockInOut.Location = new Point(563, 59);
            btnClockInOut.Name = "btnClockInOut";
            btnClockInOut.Size = new Size(520, 138);
            btnClockInOut.TabIndex = 0;
            btnClockInOut.Text = "Timekeeping";
            btnClockInOut.UseVisualStyleBackColor = false;
            btnClockInOut.Click += btnClockInOut_Click;
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.BackColor = Color.FromArgb(255, 128, 128);
            btnViewSchedule.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewSchedule.Location = new Point(563, 471);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(520, 138);
            btnViewSchedule.TabIndex = 4;
            btnViewSchedule.Text = "View Schedule";
            btnViewSchedule.UseVisualStyleBackColor = false;
            btnViewSchedule.Click += btnViewSchedule_Click;
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
            panelMenu.Size = new Size(268, 94);
            panelMenu.TabIndex = 6;
            panelMenu.WrapContents = false;
            // 
            // btnDropDownMenu
            // 
            btnDropDownMenu.FlatAppearance.BorderSize = 0;
            btnDropDownMenu.FlatStyle = FlatStyle.Flat;
            btnDropDownMenu.Image = (Image)resources.GetObject("btnDropDownMenu.Image");
            btnDropDownMenu.Location = new Point(0, 0);
            btnDropDownMenu.Margin = new Padding(0);
            btnDropDownMenu.Name = "btnDropDownMenu";
            btnDropDownMenu.Size = new Size(268, 94);
            btnDropDownMenu.TabIndex = 0;
            btnDropDownMenu.UseVisualStyleBackColor = true;
            btnDropDownMenu.Click += btnDropDownMenu_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 18F);
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 97);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(268, 81);
            btnHome.TabIndex = 6;
            btnHome.Tag = "Home";
            btnHome.Text = "          Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnTimeKeeping
            // 
            btnTimeKeeping.FlatAppearance.BorderSize = 0;
            btnTimeKeeping.FlatStyle = FlatStyle.Flat;
            btnTimeKeeping.Font = new Font("Century Gothic", 18F);
            btnTimeKeeping.Image = (Image)resources.GetObject("btnTimeKeeping.Image");
            btnTimeKeeping.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.Location = new Point(3, 184);
            btnTimeKeeping.Name = "btnTimeKeeping";
            btnTimeKeeping.Size = new Size(268, 81);
            btnTimeKeeping.TabIndex = 8;
            btnTimeKeeping.Tag = "Timekeeping";
            btnTimeKeeping.Text = "          Timekeeping";
            btnTimeKeeping.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Century Gothic", 18F);
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(3, 271);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(268, 81);
            btnSchedule.TabIndex = 12;
            btnSchedule.Tag = "Notes";
            btnSchedule.Text = "          Schedule";
            btnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnTasks
            // 
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Century Gothic", 18F);
            btnTasks.Image = (Image)resources.GetObject("btnTasks.Image");
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(3, 358);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(268, 81);
            btnTasks.TabIndex = 7;
            btnTasks.Tag = "Tasks";
            btnTasks.Text = "          Tasks";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnNotes
            // 
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Century Gothic", 18F);
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotes.Location = new Point(3, 445);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(268, 81);
            btnNotes.TabIndex = 9;
            btnNotes.Tag = "Notes";
            btnNotes.Text = "          Notes";
            btnNotes.TextAlign = ContentAlignment.MiddleLeft;
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnHelp
            // 
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Century Gothic", 18F);
            btnHelp.Image = (Image)resources.GetObject("btnHelp.Image");
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(3, 532);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(268, 81);
            btnHelp.TabIndex = 11;
            btnHelp.Tag = "Notes";
            btnHelp.Text = "          Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 18F);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(3, 619);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(268, 81);
            btnLogOut.TabIndex = 10;
            btnLogOut.Tag = "Logout";
            btnLogOut.Text = "          Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 667);
            button1.Name = "button1";
            button1.Size = new Size(178, 58);
            button1.TabIndex = 7;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1505, 737);
            Controls.Add(button1);
            Controls.Add(panelMenu);
            Controls.Add(btnViewSchedule);
            Controls.Add(btnViewTasks);
            Controls.Add(btnClockInOut);
            DoubleBuffered = true;
            MaximumSize = new Size(1521, 776);
            MinimumSize = new Size(1521, 776);
            Name = "HomePage";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CT - Home";
            Load += HomePage_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        //private void button9_Click(object sender, EventArgs e)
        //{
        //   CollapseMenu();
        // }

        //private void CollapseMenu()
        //{

        //}

        #endregion
        private Button btnViewTasks;
        private Button btnViewSchedule;
        private Button btnClockInOut;
        private FlowLayoutPanel panelMenu;
        private Button btnHome;
        private Button btnDropDownMenu;
        private Button btnLogOut;
        private Button btnNotes;
        private Button btnTimeKeeping;
        private Button btnTasks;
        private Button button1;
        private Button button2;
        private Button btnHelp;
        private Button btnSchedule;
    }
}