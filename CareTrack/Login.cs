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
        private void RemoveUserPlaceholder(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        //set placeholder
        private void SetUserPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        //password field
        //remove placeholder
        private void RemovePassPlaceholder(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "Enter Password")
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.ForeColor = Color.Black;
                maskedTextBox1.UseSystemPasswordChar = true;
            }
        }

        //set placeholder
        private void SetPassPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                maskedTextBox1.UseSystemPasswordChar = false;
                maskedTextBox1.Text = "Enter Password";
                maskedTextBox1.ForeColor = Color.Gray;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text.Trim();
            String password = maskedTextBox1.Text.Trim();

            //input hashing password
            byte[] hashedPasswordBytes;
            using (SHA256 sha256 = SHA256.Create())
            {
                hashedPasswordBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

            String query = "SELECT COUNT(*) FROM Users WHERE username = @Username AND password_hash = @Password AND isActive = 1";
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (SqlConnection connection = db.OpenConnection())
                {
                    SqlCommand loginCommand = new SqlCommand(query, connection);
                    loginCommand.Parameters.AddWithValue("@Username", username);
                    loginCommand.Parameters.Add("@Password", SqlDbType.VarBinary, 256).Value = hashedPasswordBytes;

                    
                    int result = (int)loginCommand.ExecuteScalar();
                   
                    if (result == 1)
                    {
                        //Storing CaregiverID for timekeeping
                        String idquery = "SELECT CaregiverID FROM Users WHERE username = @Username";
                        SqlCommand getIdCmd = new SqlCommand(idquery, connection);
                        getIdCmd.Parameters.AddWithValue("@Username", username);

                        object idresult = getIdCmd.ExecuteScalar();

                        int caregiverId = Convert.ToInt32(idresult);

                        //pop up boxes of success or failure
                        MessageBox.Show("Welcome, " + username + "!" + " Login Successful");
                        //passing username and caregiverid to homepage
                        HomePage home = new HomePage(username, caregiverId);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }


    }
}

