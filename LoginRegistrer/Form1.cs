using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginRegistrer
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            string username = textUsername.Text;
            string password = textPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @usn and `password` = @pass", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("User not found!");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.ForeColor = Color.Red;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.ForeColor = Color.Orange;
        }

        private void TextUsername_Enter(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            if (username.Equals("Enter Username"))
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
                textUsername.Text = "Enter Username";
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
