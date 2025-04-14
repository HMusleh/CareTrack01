namespace CareTrack
{
    partial class ClientsSignatureForm
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
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.PictureBox pictureBoxSignature;
        private System.Windows.Forms.Button btnSaveSignature;
        private System.Windows.Forms.Button btnClear;
        private RadioButton radioDraw;
        private RadioButton radioType;
        private Panel signaturePanel;
        private TextBox txtTypedSignature;

        private void InitializeComponent()
        {
            lblClients = new Label();
            btnSaveSignature = new Button();
            btnClear = new Button();
            radioDraw = new RadioButton();
            radioType = new RadioButton();
            signaturePanel = new Panel();
            txtTypedSignature = new TextBox();
            SuspendLayout();
            // 
            // lblClients
            // 
            lblClients.AutoSize = true;
            lblClients.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblClients.Location = new Point(30, 20);
            lblClients.Name = "lblClients";
            lblClients.Size = new Size(284, 31);
            lblClients.TabIndex = 4;
            lblClients.Text = "Clients Signature Form";
            lblClients.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSaveSignature
            // 
            btnSaveSignature.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveSignature.Location = new Point(50, 280);
            btnSaveSignature.Name = "btnSaveSignature";
            btnSaveSignature.Size = new Size(135, 30);
            btnSaveSignature.TabIndex = 6;
            btnSaveSignature.Text = "Save Signature";
            btnSaveSignature.Click += btnSaveSignature_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(300, 280);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 30);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // radioDraw
            // 
            radioDraw.Checked = true;
            radioDraw.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioDraw.Location = new Point(50, 70);
            radioDraw.Name = "radioDraw";
            radioDraw.Size = new Size(104, 24);
            radioDraw.TabIndex = 0;
            radioDraw.TabStop = true;
            radioDraw.Text = "Draw Signature";
            radioDraw.CheckedChanged += radioDraw_CheckedChanged;
            // 
            // radioType
            // 
            radioType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioType.Location = new Point(300, 70);
            radioType.Name = "radioType";
            radioType.Size = new Size(104, 24);
            radioType.TabIndex = 1;
            radioType.Text = "Type Name";
            radioType.CheckedChanged += radioType_CheckedChanged;
            // 
            // signaturePanel
            // 
            signaturePanel.BackColor = Color.White;
            signaturePanel.BorderStyle = BorderStyle.FixedSingle;
            signaturePanel.Location = new Point(20, 100);
            signaturePanel.Name = "signaturePanel";
            signaturePanel.Size = new Size(415, 126);
            signaturePanel.TabIndex = 2;
            signaturePanel.Paint += signaturePanel_Paint;
            signaturePanel.MouseDown += signaturePanel_MouseDown;
            signaturePanel.MouseMove += signaturePanel_MouseMove;
            signaturePanel.MouseUp += signaturePanel_MouseUp;
            // 
            // txtTypedSignature
            // 
            txtTypedSignature.Font = new Font("Times New Roman", 21.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtTypedSignature.ForeColor = SystemColors.WindowText;
            txtTypedSignature.Location = new Point(20, 100);
            txtTypedSignature.Multiline = true;
            txtTypedSignature.Name = "txtTypedSignature";
            txtTypedSignature.Size = new Size(400, 40);
            txtTypedSignature.TabIndex = 3;
            txtTypedSignature.TextAlign = HorizontalAlignment.Center;
            txtTypedSignature.Visible = false;
            // 
            // ClientsSignatureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 744);
            Controls.Add(radioDraw);
            Controls.Add(radioType);
            Controls.Add(signaturePanel);
            Controls.Add(txtTypedSignature);
            Controls.Add(lblClients);
            Controls.Add(btnSaveSignature);
            Controls.Add(btnClear);
            Name = "ClientsSignatureForm";
            Text = "ClientsSignature";
            ResumeLayout(false);
            PerformLayout();
        }
    }

    #endregion
}
