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
        public HashSet<User> users = new HashSet<User>();

        public AddNewUser()
        {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtFullName.Focus();
            txtPassword.Focus();
            txtEmail.Focus();
            rbMale.Focus();
            rbFemale.Focus();
            mcDateBirth.Focus();
            txtAboutMe.Focus();
            if (txtUsername.Text.Trim().Length > 0 && txtFullName.Text.Trim().Length > 0 && txtPassword.Text.Trim().Length > 0 && txtEmail.Text.Trim().Length > 0 && (rbMale.Checked || rbFemale.Checked) && txtDateBirth.Text.Trim().Length > 0 && txtAboutMe.Text.Trim().Length > 0)
            {
                string g;
                if(rbMale.Checked) g = gender.male.ToString();
                else g = gender.female.ToString();
                user = new User(txtUsername.Text, txtFullName.Text, txtPassword.Text, txtEmail.Text, g, txtDateBirth.Text, txtAboutMe.Text);
                // ako slika uploadedPhoto e uploadirana -> postavi ja za avatar so metodot user.ChangeAvatar(Image uploadedPhoto);
                users.Add(user);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
