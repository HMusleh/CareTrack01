namespace CareTrack
{
    partial class ShiftManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftManagerForm));
            panelMenu = new FlowLayoutPanel();
            btnDropDownMenu = new Button();
            btnHome = new Button();
            btnTimeKeeping = new Button();
            btnSchedule = new Button();
            btnTasks = new Button();
            btnNotes = new Button();
            btnHelp = new Button();
            btnLogOut = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelMonday = new Label();
            labelTuesday = new Label();
            labelWednesday = new Label();
            labelThursday = new Label();
            labelFriday = new Label();
            labelSaturday = new Label();
            labelSunday = new Label();
            button1 = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
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
            panelMenu.Location = new Point(1238, 0);
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
            btnDropDownMenu.Size = new Size(262, 107);
            btnDropDownMenu.TabIndex = 0;
            btnDropDownMenu.UseVisualStyleBackColor = true;
            btnDropDownMenu.Click += btnDropDownMenu_Click;
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
            btnHome.Location = new Point(3, 116);
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
            btnTimeKeeping.Dock = DockStyle.Top;
            btnTimeKeeping.FlatAppearance.BorderSize = 0;
            btnTimeKeeping.FlatStyle = FlatStyle.Flat;
            btnTimeKeeping.Font = new Font("Century Gothic", 18F);
            btnTimeKeeping.Image = (Image)resources.GetObject("btnTimeKeeping.Image");
            btnTimeKeeping.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.Location = new Point(3, 203);
            btnTimeKeeping.Name = "btnTimeKeeping";
            btnTimeKeeping.Size = new Size(268, 81);
            btnTimeKeeping.TabIndex = 8;
            btnTimeKeeping.Tag = "Timekeeping";
            btnTimeKeeping.Text = "          Timekeeping";
            btnTimeKeeping.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.UseVisualStyleBackColor = true;
            btnTimeKeeping.Click += btnTimeKeeping_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Century Gothic", 18F);
            btnSchedule.Image = (Image)resources.GetObject("btnSchedule.Image");
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.Location = new Point(3, 290);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(268, 81);
            btnSchedule.TabIndex = 13;
            btnSchedule.Tag = "Notes";
            btnSchedule.Text = "          Schedule";
            btnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnTasks
            // 
            btnTasks.Dock = DockStyle.Top;
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Century Gothic", 18F);
            btnTasks.Image = (Image)resources.GetObject("btnTasks.Image");
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(3, 377);
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
            btnNotes.Dock = DockStyle.Top;
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Century Gothic", 18F);
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotes.Location = new Point(3, 464);
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
            btnHelp.Location = new Point(3, 551);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(268, 81);
            btnHelp.TabIndex = 12;
            btnHelp.Tag = "Notes";
            btnHelp.Text = "          Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 18F);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(3, 638);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(268, 81);
            btnLogOut.TabIndex = 10;
            btnLogOut.Tag = "Logout";
            btnLogOut.Text = "          Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(555, 52);
            label1.Name = "label1";
            label1.Size = new Size(257, 58);
            label1.TabIndex = 7;
            label1.Text = "Schedule:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(568, 146);
            label2.Name = "label2";
            label2.Size = new Size(157, 39);
            label2.TabIndex = 8;
            label2.Text = "Monday:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(573, 236);
            label3.Name = "label3";
            label3.Size = new Size(152, 39);
            label3.TabIndex = 9;
            label3.Text = "Tuesday:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(516, 322);
            label4.Name = "label4";
            label4.Size = new Size(213, 39);
            label4.TabIndex = 10;
            label4.Text = "Wednesday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(573, 410);
            label5.Name = "label5";
            label5.Size = new Size(161, 39);
            label5.TabIndex = 11;
            label5.Text = "Thursday:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(609, 489);
            label6.Name = "label6";
            label6.Size = new Size(120, 39);
            label6.TabIndex = 12;
            label6.Text = "Friday:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(568, 574);
            label7.Name = "label7";
            label7.Size = new Size(164, 39);
            label7.TabIndex = 13;
            label7.Text = "Saturday:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(594, 652);
            label8.Name = "label8";
            label8.Size = new Size(142, 39);
            label8.TabIndex = 14;
            label8.Text = "Sunday:";
            // 
            // labelMonday
            // 
            labelMonday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMonday.Location = new Point(752, 134);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new Size(402, 70);
            labelMonday.TabIndex = 15;
            labelMonday.TextAlign = ContentAlignment.MiddleLeft;
            labelMonday.Click += labelMonday_Click;
            // 
            // labelTuesday
            // 
            labelTuesday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTuesday.Location = new Point(752, 221);
            labelTuesday.Name = "labelTuesday";
            labelTuesday.Size = new Size(402, 70);
            labelTuesday.TabIndex = 16;
            labelTuesday.TextAlign = ContentAlignment.MiddleLeft;
            labelTuesday.Click += labelTuesday_Click;
            // 
            // labelWednesday
            // 
            labelWednesday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWednesday.Location = new Point(753, 307);
            labelWednesday.Name = "labelWednesday";
            labelWednesday.Size = new Size(401, 70);
            labelWednesday.TabIndex = 17;
            labelWednesday.TextAlign = ContentAlignment.MiddleLeft;
            labelWednesday.Click += labelWednesday_Click;
            // 
            // labelThursday
            // 
            labelThursday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelThursday.Location = new Point(753, 393);
            labelThursday.Name = "labelThursday";
            labelThursday.Size = new Size(401, 70);
            labelThursday.TabIndex = 18;
            labelThursday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFriday
            // 
            labelFriday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFriday.Location = new Point(753, 476);
            labelFriday.Name = "labelFriday";
            labelFriday.Size = new Size(401, 70);
            labelFriday.TabIndex = 19;
            labelFriday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSaturday
            // 
            labelSaturday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSaturday.Location = new Point(753, 556);
            labelSaturday.Name = "labelSaturday";
            labelSaturday.Size = new Size(401, 70);
            labelSaturday.TabIndex = 20;
            labelSaturday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSunday
            // 
            labelSunday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSunday.Location = new Point(753, 640);
            labelSunday.Name = "labelSunday";
            labelSunday.Size = new Size(401, 70);
            labelSunday.TabIndex = 21;
            labelSunday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 667);
            button1.Name = "button1";
            button1.Size = new Size(178, 58);
            button1.TabIndex = 22;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = false;
            // 
            // ShiftManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1505, 737);
            Controls.Add(button1);
            Controls.Add(labelSunday);
            Controls.Add(labelSaturday);
            Controls.Add(labelFriday);
            Controls.Add(labelThursday);
            Controls.Add(labelWednesday);
            Controls.Add(labelTuesday);
            Controls.Add(labelMonday);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelMenu);
            MaximumSize = new Size(1521, 776);
            MinimumSize = new Size(1521, 776);
            Name = "ShiftManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ShiftManagerForm_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelMenu;
        private Button btnDropDownMenu;
        private Button btnHome;
        private Button btnTasks;
        private Button btnTimeKeeping;
        private Button btnNotes;
        private Button btnLogOut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelMonday;
        private Label labelTuesday;
        private Label labelWednesday;
        private Label labelThursday;
        private Label labelFriday;
        private Label labelSaturday;
        private Label labelSunday;
        private Button button1;
        private Button btnHelp;
        private Button btnSchedule;
    }
}