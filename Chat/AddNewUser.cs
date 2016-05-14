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
    public partial class AddNewUser : Form
    {
        public User user;
        public string date;
        Dictionary<string, User> users;

        public AddNewUser()
        {
            InitializeComponent();
        }

        public AddNewUser(Dictionary<string, User> u)
        {
            users = u;
            InitializeComponent();
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            mcDateBirth.MaxDate = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            mcDateBirth.ShowToday = false;
            mcDateBirth.ShowTodayCircle = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            date = e.Start.ToShortDateString();
            txtDateBirth.Text = date.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtFullName.Focus();
            txtPassword.Focus();
            txtEmail.Focus();
            mcDateBirth.Focus();
            txtAboutMe.Focus();
            if (txtUsername.Text.Trim().Length > 0 && !users.ContainsKey(txtUsername.Text) && txtFullName.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0 && txtEmail.Text.Trim().Length > 0 && txtDateBirth.Text.Trim().Length > 0 && txtAboutMe.Text.Trim().Length > 0)
            {
                string g;
                if(rbMale.Checked) g = gender.male.ToString();
                else g = gender.female.ToString();
                user = new User(txtUsername.Text, txtFullName.Text, txtPassword.Text, txtEmail.Text, g, txtDateBirth.Text, txtAboutMe.Text);
                // ako slika uploadedPhoto e uploadirana -> postavi ja za avatar so metodot user.ChangeAvatar(Image uploadedPhoto);
                users.Add(txtUsername.Text, user);
                this.DialogResult = DialogResult.OK;
                Profile form = new Profile(user, users);
                this.Hide();
                form.Show();
                Close();
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 forma = new Form1();
            forma.Show();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username field can not be empty!");
            }
            else if (users.ContainsKey(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username already exists!");
            }
            else
                errorProvider1.SetError(txtUsername, null);
            
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFullName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFullName, "FullName field can not be empty!");
            }
            else
                errorProvider1.SetError(txtFullName, null);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password field can not be empty!");
            }
            else
                errorProvider1.SetError(txtPassword, null);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "E-mail field can not be empty!");
            }
            else
                errorProvider1.SetError(txtEmail, null);
        }

        private void txtDateBirth_Validating(object sender, CancelEventArgs e)
        {
            if (txtDateBirth.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDateBirth, "Date is required!");
            }
            else
                errorProvider1.SetError(txtDateBirth, null);
        }

        private void txtAboutMe_Validating(object sender, CancelEventArgs e)
        {
            if (txtAboutMe.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAboutMe, "You must write something about you!");
            }
            else
                errorProvider1.SetError(txtAboutMe, null);
        }
    }
}
