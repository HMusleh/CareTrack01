namespace CareTrack
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            PanelMenu = new FlowLayoutPanel();
            BtnDropDownMenu = new Button();
            BtnHome = new Button();
            BtnTimeKeeping = new Button();
            BtnSchedule = new Button();
            BtnTasks = new Button();
            BtnNotes = new Button();
            BtnHelp = new Button();
            BtnLogOut = new Button();
            TutorialLabel = new Label();
            LoginTut = new LinkLabel();
            HomeTut = new LinkLabel();
            TimekeepingTut = new LinkLabel();
            ScheduleTut = new LinkLabel();
            TasksTut = new LinkLabel();
            SignatureTut = new LinkLabel();
            PanelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            PanelMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelMenu.BackColor = Color.LightCoral;
            PanelMenu.Controls.Add(BtnDropDownMenu);
            PanelMenu.Controls.Add(BtnHome);
            PanelMenu.Controls.Add(BtnTimeKeeping);
            PanelMenu.Controls.Add(BtnSchedule);
            PanelMenu.Controls.Add(BtnTasks);
            PanelMenu.Controls.Add(BtnNotes);
            PanelMenu.Controls.Add(BtnHelp);
            PanelMenu.Controls.Add(BtnLogOut);
            PanelMenu.FlowDirection = FlowDirection.TopDown;
            PanelMenu.Location = new Point(1236, 1);
            PanelMenu.Margin = new Padding(3, 2, 3, 2);
            PanelMenu.Name = "panelMenu";
            PanelMenu.Size = new Size(268, 94);
            PanelMenu.TabIndex = 7;
            PanelMenu.WrapContents = false;
            // 
            // btnDropDownMenu
            // 
            BtnDropDownMenu.FlatAppearance.BorderSize = 0;
            BtnDropDownMenu.FlatStyle = FlatStyle.Flat;
            BtnDropDownMenu.Image = (Image)resources.GetObject("btnDropDownMenu.Image");
            BtnDropDownMenu.Location = new Point(0, 0);
            BtnDropDownMenu.Margin = new Padding(0);
            BtnDropDownMenu.Name = "BtnDropDownMenu";
            BtnDropDownMenu.Size = new Size(268, 94);
            BtnDropDownMenu.TabIndex = 0;
            BtnDropDownMenu.UseVisualStyleBackColor = true;
            BtnDropDownMenu.Click += BtnDropDownMenu_Click;
            // 
            // btnHome
            // 
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Century Gothic", 18F);
            BtnHome.ForeColor = SystemColors.ActiveCaptionText;
            BtnHome.Image = (Image)resources.GetObject("btnHome.Image");
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(3, 97);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(268, 81);
            BtnHome.TabIndex = 6;
            BtnHome.Tag = "Home";
            BtnHome.Text = "          Home";
            BtnHome.TextAlign = ContentAlignment.MiddleLeft;
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // btnTimeKeeping
            // 
            BtnTimeKeeping.FlatAppearance.BorderSize = 0;
            BtnTimeKeeping.FlatStyle = FlatStyle.Flat;
            BtnTimeKeeping.Font = new Font("Century Gothic", 18F);
            BtnTimeKeeping.Image = (Image)resources.GetObject("btnTimeKeeping.Image");
            BtnTimeKeeping.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTimeKeeping.Location = new Point(3, 184);
            BtnTimeKeeping.Name = "BtnTimeKeeping";
            BtnTimeKeeping.Size = new Size(268, 81);
            BtnTimeKeeping.TabIndex = 8;
            BtnTimeKeeping.Tag = "Timekeeping";
            BtnTimeKeeping.Text = "          Timekeeping";
            BtnTimeKeeping.TextAlign = ContentAlignment.MiddleLeft;
            BtnTimeKeeping.UseVisualStyleBackColor = true;
            BtnTimeKeeping.Click += BtnTimeKeeping_Click;
            // 
            // btnSchedule
            // 
            BtnSchedule.FlatAppearance.BorderSize = 0;
            BtnSchedule.FlatStyle = FlatStyle.Flat;
            BtnSchedule.Font = new Font("Century Gothic", 18F);
            BtnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            BtnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSchedule.Location = new Point(3, 271);
            BtnSchedule.Name = "BtnSchedule";
            BtnSchedule.Size = new Size(268, 81);
            BtnSchedule.TabIndex = 12;
            BtnSchedule.Tag = "Notes";
            BtnSchedule.Text = "          Schedule";
            BtnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            BtnSchedule.UseVisualStyleBackColor = true;
            BtnSchedule.Click += BtnSchedule_Click;
            // 
            // btnTasks
            // 
            BtnTasks.FlatAppearance.BorderSize = 0;
            BtnTasks.FlatStyle = FlatStyle.Flat;
            BtnTasks.Font = new Font("Century Gothic", 18F);
            BtnTasks.Image = (Image)resources.GetObject("btnTasks.Image");
            BtnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            BtnTasks.Location = new Point(3, 358);
            BtnTasks.Name = "BtnTasks";
            BtnTasks.Size = new Size(268, 81);
            BtnTasks.TabIndex = 7;
            BtnTasks.Tag = "Tasks";
            BtnTasks.Text = "          Tasks";
            BtnTasks.TextAlign = ContentAlignment.MiddleLeft;
            BtnTasks.UseVisualStyleBackColor = true;
            BtnTasks.Click += BtnTasks_Click;
            // 
            // btnNotes
            // 
            BtnNotes.FlatAppearance.BorderSize = 0;
            BtnNotes.FlatStyle = FlatStyle.Flat;
            BtnNotes.Font = new Font("Century Gothic", 18F);
            BtnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            BtnNotes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNotes.Location = new Point(3, 445);
            BtnNotes.Name = "BtnNotes";
            BtnNotes.Size = new Size(268, 81);
            BtnNotes.TabIndex = 9;
            BtnNotes.Tag = "Notes";
            BtnNotes.Text = "          Notes";
            BtnNotes.TextAlign = ContentAlignment.MiddleLeft;
            BtnNotes.UseVisualStyleBackColor = true;   
            BtnNotes.Click += BtnNotes_Click;
            // 
            // btnHelp
            // 
            BtnHelp.FlatAppearance.BorderSize = 0;
            BtnHelp.FlatStyle = FlatStyle.Flat;
            BtnHelp.Font = new Font("Century Gothic", 18F);
            BtnHelp.Image = (Image)resources.GetObject("btnHelp.Image");
            BtnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHelp.Location = new Point(3, 532);
            BtnHelp.Name = "BtnHelp";
            BtnHelp.Size = new Size(268, 81);
            BtnHelp.TabIndex = 11;
            BtnHelp.Tag = "Notes";
            BtnHelp.Text = "          Help";
            BtnHelp.TextAlign = ContentAlignment.MiddleLeft;
            BtnHelp.UseVisualStyleBackColor = true;

            // 
            // btnLogOut
            // 
            BtnLogOut.FlatAppearance.BorderSize = 0;
            BtnLogOut.FlatStyle = FlatStyle.Flat;
            BtnLogOut.Font = new Font("Century Gothic", 18F);
            BtnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            BtnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogOut.Location = new Point(3, 619);
            BtnLogOut.Name = "BtnLogOut";
            BtnLogOut.Size = new Size(268, 81);
            BtnLogOut.TabIndex = 10;
            BtnLogOut.Tag = "Logout";
            BtnLogOut.Text = "          Logout";
            BtnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            BtnLogOut.UseVisualStyleBackColor = true;
            BtnLogOut.Click += BtnLogOut_Click;
            // 
            // TutorialLabel
            // 
            TutorialLabel.AutoSize = true;
            TutorialLabel.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TutorialLabel.Location = new Point(562, 83);
            TutorialLabel.Name = "TutorialLabel";
            TutorialLabel.Size = new Size(530, 78);
            TutorialLabel.TabIndex = 8;
            TutorialLabel.Text = "Helpful Tutorials:";
            // 
            // LoginTut
            // 
            LoginTut.AutoSize = true;
            LoginTut.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginTut.LinkColor = Color.Black;
            LoginTut.Location = new Point(573, 199);
            LoginTut.Name = "LoginTut";
            LoginTut.Size = new Size(483, 44);
            LoginTut.TabIndex = 9;
            LoginTut.TabStop = true;
            LoginTut.Text = "How To: Login and Logout";
            LoginTut.LinkClicked += ClockInLink_LinkClicked;

            // 
            // HomeTut
            // 
            HomeTut.AutoSize = true;
            HomeTut.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeTut.LinkColor = Color.Black;
            HomeTut.Location = new Point(573, 288);
            HomeTut.Name = "HomeTut";
            HomeTut.Size = new Size(654, 44);
            HomeTut.TabIndex = 10;
            HomeTut.TabStop = true;
            HomeTut.Text = "How To: Navigate the Home Screen";
            HomeTut.LinkClicked += HomeTut_LinkClicked;
            // 
            // TimekeepingTut
            // 
            TimekeepingTut.AutoSize = true;
            TimekeepingTut.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimekeepingTut.LinkColor = Color.Black;
            TimekeepingTut.Location = new Point(573, 377);
            TimekeepingTut.Name = "TimekeepingTut";
            TimekeepingTut.Size = new Size(552, 44);
            TimekeepingTut.TabIndex = 11;
            TimekeepingTut.TabStop = true;
            TimekeepingTut.Text = "How To: Clock In/Out for Shifts";
            TimekeepingTut.LinkClicked += TimekeepingTut_LinkClicked;
            // 
            // ScheduleTut
            // 
            ScheduleTut.AutoSize = true;
            ScheduleTut.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScheduleTut.LinkColor = Color.Black;
            ScheduleTut.Location = new Point(573, 466);
            ScheduleTut.Name = "ScheduleTut";
            ScheduleTut.Size = new Size(527, 44);
            ScheduleTut.TabIndex = 12;
            ScheduleTut.TabStop = true;
            ScheduleTut.Text = "How To: View Your Schedule";
            ScheduleTut.LinkClicked += ScheduleTut_LinkClicked;
            // 
            // TasksTut
            // 
            TasksTut.AutoSize = true;
            TasksTut.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TasksTut.LinkColor = Color.Black;
            TasksTut.Location = new Point(573, 555);
            TasksTut.Name = "TasksTut";
            TasksTut.Size = new Size(526, 44);
            TasksTut.TabIndex = 13;
            TasksTut.TabStop = true;
            TasksTut.Text = "How To: View/Manage Tasks";
            TasksTut.LinkClicked += TasksTut_LinkClicked;
            // 
            // SignatureTut
            // 
            SignatureTut.AutoSize = true;
            SignatureTut.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignatureTut.LinkColor = Color.Black;
            SignatureTut.Location = new Point(573, 644);
            SignatureTut.Name = "SignatureTut";
            SignatureTut.Size = new Size(642, 44);
            SignatureTut.TabIndex = 14;
            SignatureTut.TabStop = true;
            SignatureTut.Text = "How To: Save Notes and Signatures";
            SignatureTut.LinkClicked += SignatureTut_LinkClicked;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1505, 737);
            Controls.Add(SignatureTut);
            Controls.Add(TasksTut);
            Controls.Add(ScheduleTut);
            Controls.Add(TimekeepingTut);
            Controls.Add(HomeTut);
            Controls.Add(LoginTut);
            Controls.Add(TutorialLabel);
            Controls.Add(PanelMenu);
            MaximumSize = new Size(1521, 776);
            MinimumSize = new Size(1521, 776);
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help Page";
            PanelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PanelMenu;
        private Button BtnDropDownMenu;
        private Button BtnHome;
        private Button BtnTimeKeeping;
        private Button BtnSchedule;
        private Button BtnTasks;
        private Button BtnNotes;
        private Button BtnHelp;
        private Button BtnLogOut;
        private Label TutorialLabel;
        private LinkLabel LoginTut;
        private LinkLabel HomeTut;
        private LinkLabel TimekeepingTut;
        private LinkLabel ScheduleTut;
        private LinkLabel TasksTut;
        private LinkLabel SignatureTut;
    }
}