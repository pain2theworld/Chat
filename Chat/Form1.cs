using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Dictionary<string, User> users = new Dictionary<string, User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";

            User user_Dajana = new User("dajana", "Dajana Stojchevska", "lala", "dajana@finki.com", "female", "17/01/1996", "I love chocolates.");
            User user_Viktorija = new User("viki", "Viktorija Velinovska", "viktorija", "viki@hotmail.com", "female", "27/01/1996", "I love rainbow colors.");
            users.Add(user_Dajana.username, user_Dajana);
            users.Add(user_Viktorija.username, user_Viktorija);
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text))
                txtUsername.Text = "Username";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
                txtPassword.Text = "Password";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Username")
                txtUsername.ForeColor = Color.DarkCyan;
            else txtUsername.ForeColor = Color.Silver;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                txtPassword.ForeColor = Color.DarkCyan;
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewUser form = new AddNewUser(users);
            form.Show();
        }

    }
}
