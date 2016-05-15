using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Chat
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, User> users = new Dictionary<string, User>();
        public static User u;
        public static Profile form;
        
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
          user_Dajana.AddMessage(user_Viktorija, new Message("Dajana", "Hi!"));
                user_Viktorija.AddMessage(user_Dajana, new Message("Dajana", "Hi!"));
                user_Viktorija.AddMessage(user_Dajana, new Message("Viktorija", "Hey"));
                user_Dajana.AddMessage(user_Viktorija, new Message("Viktorija", "Hey"));
                user_Viktorija.AddMessage(user_Dajana, new Message("Viktorija", "What's up?"));
                user_Dajana.AddMessage(user_Viktorija, new Message("Viktorija", "What's up?"));
                users.Add(user_Dajana.username, user_Dajana);
                users.Add(user_Viktorija.username, user_Viktorija);
                users.Add("bot1", new User("bot1", "Bot Robot", "pas", "email", "male", "15/03/2005", "I love me."));
                users.Add("bot2", new User("bot2", "Superbot Botovski", "pas", "email", "female", "15/12/1985", "I love me."));
            
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
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!users.TryGetValue(txtUsername.Text, out u))
                MessageBox.Show("Username does not exist! Register first.");
            else
            {
                if (u.password != txtPassword.Text)
                    MessageBox.Show("Wrong password!");
                else
                {
                    this.Hide();
                    form = new Profile(u, users, true);
                    form.Show();
                }
            }
        }

    }
}
