
namespace CareTrack
{
    partial class Signatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signatures));
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            panelMenu = new FlowLayoutPanel();
            btnDropDownMenu = new Button();
            btnHome = new Button();
            btnTimeKeeping = new Button();
            btnSchedule = new Button();
            btnTasks = new Button();
            btnNotes = new Button();
            btnHelp = new Button();
            btnLogOut = new Button();
            btnClientSign = new Button();
            btnCaregiverSign = new Button();
            button1 = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveBorder;
            richTextBox1.Location = new Point(550, 155);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(545, 208);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(537, 74);
            label1.Name = "label1";
            label1.Size = new Size(414, 58);
            label1.TabIndex = 1;
            label1.Text = "Caregiver Notes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(537, 381);
            label2.Name = "label2";
            label2.Size = new Size(273, 58);
            label2.TabIndex = 2;
            label2.Text = "Signatures:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(550, 468);
            label3.Name = "label3";
            label3.Size = new Size(116, 39);
            label3.TabIndex = 4;
            label3.Text = "Client:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(550, 546);
            label4.Name = "label4";
            label4.Size = new Size(184, 39);
            label4.TabIndex = 5;
            label4.Text = "Caregiver:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 128, 128);
            btnSubmit.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(550, 615);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(559, 85);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
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
            panelMenu.Location = new Point(1237, 1);
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
            btnHelp.TabIndex = 12;
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
            // btnClientSign
            // 
            btnClientSign.BackColor = Color.FromArgb(255, 128, 128);
            btnClientSign.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            btnClientSign.Location = new Point(740, 473);
            btnClientSign.Name = "btnClientSign";
            btnClientSign.Size = new Size(234, 34);
            btnClientSign.TabIndex = 0;
            btnClientSign.Text = "Sign Here";
            btnClientSign.UseVisualStyleBackColor = false;
            btnClientSign.Click += BtnClientSign_Click;
            // 
            // btnCaregiverSign
            // 
            btnCaregiverSign.BackColor = Color.FromArgb(255, 128, 128);
            btnCaregiverSign.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            btnCaregiverSign.Location = new Point(740, 551);
            btnCaregiverSign.Name = "btnCaregiverSign";
            btnCaregiverSign.Size = new Size(234, 34);
            btnCaregiverSign.TabIndex = 1;
            btnCaregiverSign.Text = "Sign Here";
            btnCaregiverSign.UseVisualStyleBackColor = false;
            btnCaregiverSign.Click += BtnCaregiverSign_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 667);
            button1.Name = "button1";
            button1.Size = new Size(178, 58);
            button1.TabIndex = 8;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click_1;
            // 
            // Signatures
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1505, 737);
            Controls.Add(button1);
            Controls.Add(btnClientSign);
            Controls.Add(btnCaregiverSign);
            Controls.Add(panelMenu);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            MaximumSize = new Size(1521, 776);
            MinimumSize = new Size(1521, 776);
            Name = "Signatures";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes Page";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSubmit;
        private FlowLayoutPanel panelMenu;
       
        private Button btnDropDownMenu;
        private Button btnHome;
        private Button btnTasks;
        private Button btnTimeKeeping;
        private Button btnNotes;
        private Button btnLogOut;
        private Button btnCaregiverSign;
        private Button btnClientSign;
        private Button button1;
        private Button btnHelp;
        private Button btnSchedule;
    }
}