using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginRegistrer
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void TextForename_Enter(object sender, EventArgs e)
        {
            String firstName = textForename.Text;
            if (firstName.Equals("Forename"))
            {
                textForename.Text = "";
                textForename.ForeColor = Color.Black;
            }
        }

        private void TextForename_Leave(object sender, EventArgs e)
        {
            String firstName = textForename.Text;
            if (firstName.ToLower().Trim().Equals(""))
            {
                textForename.Text = "Forename";
                textForename.ForeColor = Color.Gray;
            }
        }

        private void TextForename_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextLastName_Enter(object sender, EventArgs e)
        {
            String lastName = textLastName.Text;
            if (lastName.Equals("Surname"))
            {
                textLastName.Text = "";
                textLastName.ForeColor = Color.Black;
            }
        }

        private void TextLastName_Leave(object sender, EventArgs e)
        {
            string lastName = textLastName.Text;
            if (lastName.ToLower().Trim().Equals(""))
            {
                textLastName.Text = "Surname";
                textLastName.ForeColor = Color.Gray;

            }
        }

        private void TextEmail_Enter(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            if (email.Equals("example@companyemail.com"))
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void TextEmail_Leave(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            if (email.ToLower().Trim().Equals(""))
            {
                textEmail.Text = "example@companyemail.com";
                textEmail.ForeColor = Color.Gray;
            }
        }

        private void TextUsername_Enter(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            if (username.Equals("Preferred username"))
            {
                textUsername.Text = "";
                textUsername.ForeColor = Color.Black;
            }
        }

        private void TextUsername_Leave(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            if (username.ToLower().Trim().Equals(""))
            {
                textUsername.Text = "Preferred username";
                textUsername.ForeColor = Color.Gray;
            }
        }

        private void TextPassword_Enter(object sender, EventArgs e)
        {
            string password = textPassword.Text;
            if (password.Equals("Password"))
            {
                textPassword.Text = "";
                textPassword.UseSystemPasswordChar = true;
                textPassword.ForeColor = Color.Black;
            }
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {
            string password = textPassword.Text;
            if (password.ToLower().Trim().Equals(""))
            {
                textPassword.Text = "Password";
                textPassword.UseSystemPasswordChar = false;
                textPassword.ForeColor = Color.Gray;
            }
        }

        private void TextPasswordConfirm_Enter(object sender, EventArgs e)
        {
            string passwordConfirm = textPasswordConfirm.Text;
            if (passwordConfirm.Equals("Confirm Password"))
            {
                textPasswordConfirm.Text = "";
                textPasswordConfirm.UseSystemPasswordChar = true;
                textPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void TextPasswordConfirm_Leave(object sender, EventArgs e)
        {
            string passwordConfirm = textPasswordConfirm.Text;
            if (passwordConfirm.ToLower().Trim().Equals(""))
            {
                textPasswordConfirm.Text = "Confirm Password";
                textPasswordConfirm.UseSystemPasswordChar = false;
                textPasswordConfirm.ForeColor = Color.Gray;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.ForeColor = Color.Red;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.ForeColor = Color.Orange;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`forename`, `surname`, `email`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.GetConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textForename.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textLastName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textPassword.Text;

            db.OpenConnection();

            //Textbox change function
            if (!CheckTextBoxes())
            {
                if (textPasswordConfirm.Text == textPassword.Text)
                {
                    //Username function
                    if (CheckUsername())
                    {
                        MessageBox.Show("This Username already exists, choose a different one.");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Welcome, Account has been created");
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Error, please try again later");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match.");
                }
            }
            else
            {
                MessageBox.Show("Please make sure all boxes are filled.");

            }

            db.CloseConnection();
        }
        //Checks to see if Username has been taken
        public Boolean CheckUsername()
        {

            DB db = new DB();

            string username = textUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checks if textboxes are changed
        public Boolean CheckTextBoxes()
        {
            string fname = textForename.Text;
            string lname = textLastName.Text;
            string email = textEmail.Text;
            string user = textUsername.Text;
            string pass = textPassword.Text;
            string passConfirm = textPasswordConfirm.Text;

            if (fname.Equals("Forename") || lname.Equals("Surname") || email.Equals("example@companyemail.com") || user.Equals("Preferred username") || pass.Equals("Password") || passConfirm.Equals("Confirm Password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
