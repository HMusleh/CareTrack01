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
            btnTasks = new Button();
            btnTimeKeeping = new Button();
            btnNotes = new Button();
            btnLogOut = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(946, 180);
            label1.Name = "label1";
            label1.Size = new Size(324, 40);
            label1.TabIndex = 0;
            label1.Text = "Shift starts at: 00:00";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(946, 469);
            label2.Name = "label2";
            label2.Size = new Size(320, 40);
            label2.TabIndex = 1;
            label2.Text = "Shift ends at: 00:00";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(758, 228);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(641, 125);
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
            button2.Location = new Point(758, 517);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(641, 125);
            button2.TabIndex = 7;
            button2.Text = "Clock Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            btnHome.Size = new Size(303, 108);
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
            btnTasks.Size = new Size(303, 108);
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
            btnTimeKeeping.Size = new Size(303, 108);
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
            btnNotes.Size = new Size(303, 108);
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
            btnLogOut.Size = new Size(303, 108);
            btnLogOut.TabIndex = 10;
            btnLogOut.Tag = "Logout";
            btnLogOut.Text = "          Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Timekeeping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1720, 983);
            Controls.Add(panelMenu);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Timekeeping";
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
    }
}