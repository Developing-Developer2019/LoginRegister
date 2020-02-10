using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            //this.textPassword.Size = new Size(this.textPassword.Size.Width, 50);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
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

            if(table.Rows.Count > 1)
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("User not found!");
            }

        }
    }
}
