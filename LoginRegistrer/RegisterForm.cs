using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrer
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
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

        private void textForename_Leave(object sender, EventArgs e)
        {
            String firstName = textForename.Text;
            if (firstName.ToLower().Trim().Equals(""))
            {
                textForename.Text = "Forename";
                textForename.ForeColor = Color.Gray;
            }
        }

        private void textForename_TextChanged(object sender, EventArgs e)
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

        private void textLastName_Leave(object sender, EventArgs e)
        {
            string lastName = textLastName.Text;
            if (lastName.ToLower().Trim().Equals(""))
            {
                textLastName.Text = "Surname";
                textLastName.ForeColor = Color.Gray;

            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            if (email.Equals("example@companyemail.com"))
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            if (email.ToLower().Trim().Equals(""))
            {
                textEmail.Text = "example@companyemail.com";
                textEmail.ForeColor = Color.Gray;
            }
        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            if (username.Equals("Preferred username"))
            {
                textUsername.Text = "";
                textUsername.ForeColor = Color.Black;
            }
        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            if (username.ToLower().Trim().Equals(""))
            {
                textUsername.Text = "Preferred username";
                textUsername.ForeColor = Color.Gray;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            string password = textPassword.Text;
            if (password.Equals("Password"))
            {
                textPassword.Text = "";
                textPassword.UseSystemPasswordChar = true;
                textPassword.ForeColor = Color.Black;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            string password = textPassword.Text;
            if (password.ToLower().Trim().Equals(""))
            {
                textPassword.Text = "Password";
                textPassword.UseSystemPasswordChar = false;
                textPassword.ForeColor = Color.Gray;
            }
        }

        private void textPasswordConfirm_Enter(object sender, EventArgs e)
        {
            string passwordConfirm = textPasswordConfirm.Text;
            if (passwordConfirm.Equals("Confirm Password"))
            {
                textPasswordConfirm.Text = "";
                textPasswordConfirm.UseSystemPasswordChar = true;
                textPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void textPasswordConfirm_Leave(object sender, EventArgs e)
        {
            string passwordConfirm = textPasswordConfirm.Text;
            if (passwordConfirm.ToLower().Trim().Equals(""))
            {
                textPasswordConfirm.Text = "Confirm Password";
                textPasswordConfirm.UseSystemPasswordChar = false;
                textPasswordConfirm.ForeColor = Color.Gray;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Orange;
        }
    }
}
