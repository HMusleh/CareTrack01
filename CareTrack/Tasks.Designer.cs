namespace CareTrack
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            button1 = new Button();
            label1 = new Label();
            panelMenu = new FlowLayoutPanel();
            panel1 = new Panel();
            button9 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            TableTasks = new TableLayoutPanel();
            paneltasks = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            paneltasks.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(799, 807);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(517, 81);
            button1.TabIndex = 10;
            button1.Text = "Save and Continue";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(799, 42);
            label1.Name = "label1";
            label1.Size = new Size(199, 70);
            label1.TabIndex = 12;
            label1.Text = "Tasks:";
            label1.Click += label1_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightCoral;
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button8);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(1414, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(306, 983);
            panelMenu.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 151);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(3, 0);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(299, 147);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 18F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 163);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(303, 108);
            button2.TabIndex = 6;
            button2.Tag = "Home";
            button2.Text = "          Home";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 18F);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 279);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(303, 108);
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
            button6.Location = new Point(3, 395);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(303, 108);
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
            button7.Location = new Point(3, 511);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(303, 108);
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
            button8.Location = new Point(3, 627);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(303, 108);
            button8.TabIndex = 10;
            button8.Tag = "Logout";
            button8.Text = "          Logout";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            // 
            // TableTasks
            // 
            TableTasks.AutoSize = true;
            TableTasks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableTasks.ColumnCount = 1;
            TableTasks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableTasks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableTasks.Dock = DockStyle.Top;
            TableTasks.Location = new Point(0, 0);
            TableTasks.Name = "TableTasks";
            TableTasks.RowCount = 2;
            TableTasks.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableTasks.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableTasks.Size = new Size(826, 0);
            TableTasks.TabIndex = 14;
            // 
            // paneltasks
            // 
            paneltasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            paneltasks.AutoScroll = true;
            paneltasks.Controls.Add(TableTasks);
            paneltasks.Location = new Point(548, 130);
            paneltasks.Name = "paneltasks";
            paneltasks.Size = new Size(826, 670);
            paneltasks.TabIndex = 15;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1720, 983);
            Controls.Add(paneltasks);
            Controls.Add(panelMenu);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tasks";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            paneltasks.ResumeLayout(false);
            paneltasks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private FlowLayoutPanel panelMenu;
        private Panel panel1;
        private Button button9;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TableLayoutPanel TableTasks;
        private Panel paneltasks;
    }
}