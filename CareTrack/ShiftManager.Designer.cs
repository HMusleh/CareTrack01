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
            btnTasks = new Button();
            btnTimeKeeping = new Button();
            btnNotes = new Button();
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
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMenu.BackColor = Color.LightCoral;
            panelMenu.Controls.Add(btnDropDownMenu);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnTasks);
            panelMenu.Controls.Add(btnTimeKeeping);
            panelMenu.Controls.Add(btnNotes);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.FlowDirection = FlowDirection.TopDown;
            panelMenu.Location = new Point(1206, 21);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(306, 147);
            panelMenu.TabIndex = 6;
            panelMenu.WrapContents = false;
            // 
            // btnDropDownMenu
            // 
            btnDropDownMenu.FlatAppearance.BorderSize = 0;
            btnDropDownMenu.FlatStyle = FlatStyle.Flat;
            btnDropDownMenu.Image = (Image)resources.GetObject("btnDropDownMenu.Image");
            btnDropDownMenu.Location = new Point(3, 4);
            btnDropDownMenu.Margin = new Padding(3, 4, 3, 4);
            btnDropDownMenu.Name = "btnDropDownMenu";
            btnDropDownMenu.Size = new Size(299, 147);
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
            btnHome.Location = new Point(3, 159);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(299, 108);
            btnHome.TabIndex = 6;
            btnHome.Tag = "Home";
            btnHome.Text = "          Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnTasks
            // 
            btnTasks.Dock = DockStyle.Top;
            btnTasks.FlatAppearance.BorderSize = 0;
            btnTasks.FlatStyle = FlatStyle.Flat;
            btnTasks.Font = new Font("Century Gothic", 18F);
            btnTasks.Image = (Image)resources.GetObject("btnTasks.Image");
            btnTasks.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasks.Location = new Point(3, 275);
            btnTasks.Margin = new Padding(3, 4, 3, 4);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(299, 108);
            btnTasks.TabIndex = 7;
            btnTasks.Tag = "Tasks";
            btnTasks.Text = "          Tasks";
            btnTasks.TextAlign = ContentAlignment.MiddleLeft;
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnTimeKeeping
            // 
            btnTimeKeeping.Dock = DockStyle.Top;
            btnTimeKeeping.FlatAppearance.BorderSize = 0;
            btnTimeKeeping.FlatStyle = FlatStyle.Flat;
            btnTimeKeeping.Font = new Font("Century Gothic", 18F);
            btnTimeKeeping.Image = (Image)resources.GetObject("btnTimeKeeping.Image");
            btnTimeKeeping.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.Location = new Point(3, 391);
            btnTimeKeeping.Margin = new Padding(3, 4, 3, 4);
            btnTimeKeeping.Name = "btnTimeKeeping";
            btnTimeKeeping.Size = new Size(299, 108);
            btnTimeKeeping.TabIndex = 8;
            btnTimeKeeping.Tag = "Timekeeping";
            btnTimeKeeping.Text = "          Timekeeping";
            btnTimeKeeping.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeKeeping.UseVisualStyleBackColor = true;
            btnTimeKeeping.Click += btnTimeKeeping_Click;
            // 
            // btnNotes
            // 
            btnNotes.Dock = DockStyle.Top;
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Century Gothic", 18F);
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotes.Location = new Point(3, 507);
            btnNotes.Margin = new Padding(3, 4, 3, 4);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(299, 108);
            btnNotes.TabIndex = 9;
            btnNotes.Tag = "Notes";
            btnNotes.Text = "          Notes";
            btnNotes.TextAlign = ContentAlignment.MiddleLeft;
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 18F);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(3, 623);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(299, 108);
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
            label1.Location = new Point(510, 94);
            label1.Name = "label1";
            label1.Size = new Size(323, 74);
            label1.TabIndex = 7;
            label1.Text = "Schedule:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(525, 219);
            label2.Name = "label2";
            label2.Size = new Size(195, 49);
            label2.TabIndex = 8;
            label2.Text = "Monday:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(530, 338);
            label3.Name = "label3";
            label3.Size = new Size(190, 49);
            label3.TabIndex = 9;
            label3.Text = "Tuesday:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(465, 454);
            label4.Name = "label4";
            label4.Size = new Size(265, 49);
            label4.TabIndex = 10;
            label4.Text = "Wednesday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(530, 570);
            label5.Name = "label5";
            label5.Size = new Size(200, 49);
            label5.TabIndex = 11;
            label5.Text = "Thursday:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(572, 676);
            label6.Name = "label6";
            label6.Size = new Size(148, 49);
            label6.TabIndex = 12;
            label6.Text = "Friday:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(525, 789);
            label7.Name = "label7";
            label7.Size = new Size(205, 49);
            label7.TabIndex = 13;
            label7.Text = "Saturday:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(554, 893);
            label8.Name = "label8";
            label8.Size = new Size(176, 49);
            label8.TabIndex = 14;
            label8.Text = "Sunday:";
            // 
            // labelMonday
            // 
            labelMonday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMonday.Location = new Point(735, 202);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new Size(459, 94);
            labelMonday.TabIndex = 15;
            labelMonday.TextAlign = ContentAlignment.MiddleLeft;
            labelMonday.Click += labelMonday_Click;
            // 
            // labelTuesday
            // 
            labelTuesday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTuesday.Location = new Point(735, 319);
            labelTuesday.Name = "labelTuesday";
            labelTuesday.Size = new Size(459, 94);
            labelTuesday.TabIndex = 16;
            labelTuesday.TextAlign = ContentAlignment.MiddleLeft;
            labelTuesday.Click += labelTuesday_Click;
            // 
            // labelWednesday
            // 
            labelWednesday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWednesday.Location = new Point(736, 433);
            labelWednesday.Name = "labelWednesday";
            labelWednesday.Size = new Size(458, 94);
            labelWednesday.TabIndex = 17;
            labelWednesday.TextAlign = ContentAlignment.MiddleLeft;
            labelWednesday.Click += labelWednesday_Click;
            // 
            // labelThursday
            // 
            labelThursday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelThursday.Location = new Point(736, 548);
            labelThursday.Name = "labelThursday";
            labelThursday.Size = new Size(458, 94);
            labelThursday.TabIndex = 18;
            labelThursday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFriday
            // 
            labelFriday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFriday.Location = new Point(736, 659);
            labelFriday.Name = "labelFriday";
            labelFriday.Size = new Size(458, 94);
            labelFriday.TabIndex = 19;
            labelFriday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSaturday
            // 
            labelSaturday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSaturday.Location = new Point(736, 765);
            labelSaturday.Name = "labelSaturday";
            labelSaturday.Size = new Size(458, 94);
            labelSaturday.TabIndex = 20;
            labelSaturday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSunday
            // 
            labelSunday.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSunday.Location = new Point(736, 877);
            labelSunday.Name = "labelSunday";
            labelSunday.Size = new Size(458, 94);
            labelSunday.TabIndex = 21;
            labelSunday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ShiftManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1594, 1007);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShiftManagerForm";
            Text = "Form1";
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
    }
}