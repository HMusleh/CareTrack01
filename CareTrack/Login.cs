using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;
namespace CareTrack
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            button1.Click += button1_Click; //event handler
            button2.Click += HelpButton_Click;


            //username text box edit
            textBox1.Text = "Enter Username";
            textBox1.ForeColor = Color.Gray;
            textBox1.Enter += RemoveUserPlaceholder;
            textBox1.Leave += SetUserPlaceholder;

            //password textbox edit
            maskedTextBox1.Text = "Enter Password";
            maskedTextBox1.ForeColor = Color.Gray;
            maskedTextBox1.UseSystemPasswordChar = false;
            maskedTextBox1.Enter += RemovePassPlaceholder;
            maskedTextBox1.Leave += SetPassPlaceholder;

            //different focus point
            this.ActiveControl = button1;


        }
        //username field
        //remove placeholder
        private void RemoveUserPlaceholder(object? sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        //set placeholder
        private void SetUserPlaceholder(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        //password field
        //remove placeholder
        private void RemovePassPlaceholder(object? sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "Enter Password")
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.ForeColor = Color.Black;
                maskedTextBox1.UseSystemPasswordChar = true;
            }
        }

        //set placeholder
        private void SetPassPlaceholder(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                maskedTextBox1.UseSystemPasswordChar = false;
                maskedTextBox1.Text = "Enter Password";
                maskedTextBox1.ForeColor = Color.Gray;
            }
        }
        private void button1_Click(object? sender, EventArgs e)
        {
            String username = textBox1.Text.Trim();
            String password = maskedTextBox1.Text.Trim();

            //input hashing password
            byte[] hashedPasswordBytes;
            hashedPasswordBytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));

            String query = "SELECT COUNT(*) FROM Users WHERE username = @Username AND password_hash = @Password AND isActive = 1";
            try
            {
                DatabaseHelper db = new();
                using SqlConnection connection = db.OpenConnection();
                SqlCommand loginCommand = new(query, connection);
                loginCommand.Parameters.AddWithValue("@Username", username);
                loginCommand.Parameters.Add("@Password", SqlDbType.VarBinary, 256).Value = hashedPasswordBytes;


                int result = (int)loginCommand.ExecuteScalar();

                if (result == 1)
                {
                    //Storing CaregiverID for timekeeping
                    String idquery = "SELECT CaregiverID FROM Users WHERE username = @Username";
                    SqlCommand getIdCmd = new(idquery, connection);
                    getIdCmd.Parameters.AddWithValue("@Username", username);

                    object idresult = getIdCmd.ExecuteScalar();

                    int caregiverId = Convert.ToInt32(idresult);

                    //pop up boxes of success or failure
                    PopSuccessForm successPopup = new("Welcome, " + username + "!" + " Login Successful");
                    DialogResult resultPopup = successPopup.ShowDialog();

                    if (resultPopup == DialogResult.OK)
                    {
                        HomePage home = new(username, caregiverId);
                        home.Show();
                        this.Hide();
                    }

                }
                else
                {
                    PopErrorForm errorPopup = new("Invalid Username or Password");
                    errorPopup.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                PopErrorForm errorPopup = new("Database error: " + ex.Message);
                errorPopup.ShowDialog();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                button1.PerformClick(); // Simulates the login button click
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void HelpButton_Click(object? sender, EventArgs e)
        {
            Help helpForm = new();
            helpForm.ShowDialog();
        }




        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact your supervisor to recover your username.", "Forgot Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact your supervisor to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

