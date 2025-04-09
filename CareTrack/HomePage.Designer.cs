
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
            btnTasks = new Button();
            btnTimeKeeping = new Button();
            btnNotes = new Button();
            btnLogOut = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnViewTasks
            // 
            btnViewTasks.BackColor = Color.FromArgb(255, 128, 128);
            btnViewTasks.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewTasks.Location = new Point(758, 352);
            btnViewTasks.Margin = new Padding(3, 4, 3, 4);
            btnViewTasks.Name = "btnViewTasks";
            btnViewTasks.Size = new Size(594, 184);
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
            btnClockInOut.Location = new Point(758, 77);
            btnClockInOut.Margin = new Padding(3, 4, 3, 4);
            btnClockInOut.Name = "btnClockInOut";
            btnClockInOut.Size = new Size(594, 184);
            btnClockInOut.TabIndex = 0;
            btnClockInOut.Text = "Clock In/Out";
            btnClockInOut.UseVisualStyleBackColor = false;
            btnClockInOut.Click += btnClockInOut_Click;
            // 
            // btnViewSchedule
            // 
            btnViewSchedule.BackColor = Color.FromArgb(255, 128, 128);
            btnViewSchedule.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewSchedule.Location = new Point(758, 627);
            btnViewSchedule.Margin = new Padding(3, 4, 3, 4);
            btnViewSchedule.Name = "btnViewSchedule";
            btnViewSchedule.Size = new Size(594, 184);
            btnViewSchedule.TabIndex = 4;
            btnViewSchedule.Text = "View Schedule";
            btnViewSchedule.UseVisualStyleBackColor = false;
            btnViewSchedule.Click += btnViewSchedule_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightCoral;
            panelMenu.Size = new Size(306, btnDropDownMenu.Height);
            panelMenu.Location = new Point(this.ClientSize.Width - panelMenu.Width, 0);
            panelMenu.Location = new Point(1414, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.TabIndex = 6;
            panelMenu.AutoSize = false;
            panelMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMenu.FlowDirection = FlowDirection.TopDown;
            panelMenu.WrapContents = false;
            panelMenu.Controls.Add(btnDropDownMenu);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnTasks);
            panelMenu.Controls.Add(btnTimeKeeping);
            panelMenu.Controls.Add(btnNotes);
            panelMenu.Controls.Add(btnLogOut);
            // 
            // btnDropDownMenu
            // 
            btnDropDownMenu.FlatAppearance.BorderSize = 0;
            btnDropDownMenu.FlatStyle = FlatStyle.Flat;
            btnDropDownMenu.Image = (Image)resources.GetObject("btnDropDownMenu.Image");
            btnDropDownMenu.Location = new Point(0, 0);
            btnDropDownMenu.Margin = new Padding(0);
            btnDropDownMenu.Name = "btnDropDownMenu";
            btnDropDownMenu.Size = new Size(306, 125);
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
            btnHome.Location = new Point(3, 129);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(306, 108);
            btnHome.TabIndex = 6;
            btnHome.Tag = "Home";
            btnHome.Text = "          Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnTasks
            // 
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Century Gothic", 18F);
            btnTasks.Image = (Image)resources.GetObject("btnTasks.Image");
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(3, 245);
            btnTasks.Margin = new Padding(3, 4, 3, 4);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(306, 108);
            btnTasks.TabIndex = 7;
            btnTasks.Tag = "Tasks";
            btnTasks.Text = "          Tasks";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnTimeKeeping
            // 
            btnTimeKeeping.FlatAppearance.BorderSize = 0;
            btnTimeKeeping.FlatStyle = FlatStyle.Flat;
            btnTimeKeeping.Font = new Font("Century Gothic", 18F);
            btnTimeKeeping.Image = (Image)resources.GetObject("btnTimeKeeping.Image");
            btnTimeKeeping.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.Location = new Point(3, 361);
            btnTimeKeeping.Margin = new Padding(3, 4, 3, 4);
            btnTimeKeeping.Name = "btnTimeKeeping";
            btnTimeKeeping.Size = new Size(306, 108);
            btnTimeKeeping.TabIndex = 8;
            btnTimeKeeping.Tag = "Timekeeping";
            btnTimeKeeping.Text = "          Timekeeping";
            btnTimeKeeping.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.UseVisualStyleBackColor = true;
            // 
            // btnNotes
            // 
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Century Gothic", 18F);
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotes.Location = new Point(3, 477);
            btnNotes.Margin = new Padding(3, 4, 3, 4);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(306, 108);
            btnNotes.TabIndex = 9;
            btnNotes.Tag = "Notes";
            btnNotes.Text = "          Notes";
            btnNotes.TextAlign = ContentAlignment.MiddleLeft;
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 18F);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(3, 593);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(306, 108);
            btnLogOut.TabIndex = 10;
            btnLogOut.Tag = "Logout";
            btnLogOut.Text = "          Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1720, 888);
            Controls.Add(panelMenu);
            Controls.Add(btnViewSchedule);
            Controls.Add(btnViewTasks);
            Controls.Add(btnClockInOut);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomePage";
            RightToLeft = RightToLeft.No;
            Text = "CT - Home";
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
    }
}