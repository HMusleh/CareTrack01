
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
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
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
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveBorder;
            richTextBox1.Location = new Point(549, 180);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(622, 276);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(565, 102);
            label1.Name = "label1";
            label1.Size = new Size(521, 74);
            label1.TabIndex = 1;
            label1.Text = "Caregiver Notes:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(565, 470);
            label2.Name = "label2";
            label2.Size = new Size(344, 74);
            label2.TabIndex = 2;
            label2.Text = "Signatures:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(703, 561);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(592, 44);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here to sign with DocuSign";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(549, 561);
            label3.Name = "label3";
            label3.Size = new Size(148, 49);
            label3.TabIndex = 4;
            label3.Text = "Client:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(549, 639);
            label4.Name = "label4";
            label4.Size = new Size(228, 49);
            label4.TabIndex = 5;
            label4.Text = "Caregiver:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.DodgerBlue;
            linkLabel2.Location = new Point(794, 645);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(592, 44);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Click here to sign with DocuSign";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(602, 727);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(639, 113);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
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
            panelMenu.Location = new Point(1389, 16);
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
            // Signatures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1720, 983);
            Controls.Add(panelMenu);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Signatures";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel2;
        private Button button1;
        private FlowLayoutPanel panelMenu;
        private Panel panel1;
        private Button btnDropDownMenu;
        private Button btnHome;
        private Button btnTasks;
        private Button btnTimeKeeping;
        private Button btnNotes;
        private Button btnLogOut;
    }
}