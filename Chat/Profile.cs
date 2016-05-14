﻿using System;
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
    public partial class picGender : Form
    {
        Form1 f1 = new Form1();
        User active;
        Dictionary<string, User> users;
        public Dictionary<int, Image> avatar;

        public picGender()
        {
            InitializeComponent();
        }

        public picGender(User u, Dictionary<string, User> all)
        {
            active = u;
            users = all;
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblDateBirth.Text = active.dateBirth;
            avatar = new Dictionary<int, Image>();
            avatar.Add(1, Chat.Properties.Resources.f_3);
            imgAvatar.Image = avatar[1];
            toolTip1.SetToolTip(btnGame, "You can play game");
            toolTip1.SetToolTip(btnFriends, "See your friends");
            toolTip1.SetToolTip(btnSignOut, "Sign Out");
            toolTip1.SetToolTip(edit, "Edit your profile");
            string[] parts = active.fullname.Split(' ');
            lblName.Text = parts[0];
            lblSurname.Text = parts[1];
            imgGender.Image = setGenderImage(active.gender);
            lblMail.Text = active.email;
            about.Text = active.description;
            parts = active.dateBirth.Split('.');
            lblDateBirth.Text = parts[0] + " " + setMonth(Convert.ToInt32(parts[1]));
            lblAge.Text =Age(DateTime.Now.ToString(), active.dateBirth).ToString();
            imgZodiacSign.Image =ZodiacSign(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]));
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatUsers friends = new ChatUsers(active, users);
            friends.Show();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            LettersGame igra = new LettersGame();
            igra.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 odjava = new Form1();
            odjava.Show();
        }

        public Image profilePicture(string gender, Random r)
        {
            Image picture;
            if (gender.Equals("male"))
            {
                avatar.Add(1, Chat.Properties.Resources.m_1);
                avatar.Add(2, Chat.Properties.Resources.m_2);
                avatar.Add(3, Chat.Properties.Resources.m_3);
                avatar.Add(4, Chat.Properties.Resources.m_4);
                avatar.Add(5, Chat.Properties.Resources.m_5);
                picture = avatar[r.Next(1, 6)];
            }
            else
            {
                avatar.Add(1, Chat.Properties.Resources.f_1);
                avatar.Add(2, Chat.Properties.Resources.f_2);
                avatar.Add(3, Chat.Properties.Resources.f_3);
                avatar.Add(4, Chat.Properties.Resources.f_4);
                avatar.Add(5, Chat.Properties.Resources.f_5);
                avatar.Add(6, Chat.Properties.Resources.f_6);
                picture = avatar[r.Next(1, 7)];

            }
            return picture;
        }
        public Image setGenderImage(String gender)
        {
            if (gender.Equals("female"))
                return Chat.Properties.Resources.female;
            else return Chat.Properties.Resources.male;
        }

        public String setMonth(Int32 n)
        {
            if (n == 1)
                return "January";
            else if (n == 2)
                return "February";
            else if (n == 3)
                return "March";
            else if (n == 4)
                return "April";
            else if (n == 5)
                return "May";
            else if (n == 6)
                return "June";
            else if (n == 7)
                return "July";
            else if (n == 8)
                return "August";
            else if (n == 9)
                return "September";
            else if (n == 10)
                return "October";
            else if (n == 11)
                return "November";
            else
                return "December";
        }

        public int Age(string today, string birthday)
            {
            string[] parts = today.Split(' ');
            string[] now = parts[0].Split('.');
            string[] birth = birthday.Split('.');
            if (Convert.ToInt32(now[1]) > Convert.ToInt32(birth[1]))
                return Convert.ToInt32(now[2]) - Convert.ToInt32(birth[2]);
           else if (Convert.ToInt32(now[1]) < Convert.ToInt32(birth[1]))
                return Convert.ToInt32(now[2]) - Convert.ToInt32(birth[2])-1;
            else
            {
                if (Convert.ToInt32(now[0]) >= Convert.ToInt32(birth[0]))
                    return Convert.ToInt32(now[2]) - Convert.ToInt32(birth[2]);

                return Convert.ToInt32(now[2]) - Convert.ToInt32(birth[2]) - 1; ;
            }

        }

        public Image ZodiacSign(int day, int m)
        {
          
            if ((day >= 20 && m == 1) || (day <= 18 && m == 2))
                return Chat.Properties.Resources.vodolija;
            else if ((day >= 19 && m == 2) || (day <= 20 && m == 3))
                return Chat.Properties.Resources.ribi;
            else if ((day >= 21 && m == 3) || (day <= 19 && m == 4))
                return Chat.Properties.Resources.oven;
            else if ((day >= 20 && m == 4) || (day <= 20 && m == 5))
                return Chat.Properties.Resources.bik;
            else if ((day >= 21 && m == 5) || (day <= 20 && m == 6))
                return Chat.Properties.Resources.bliznaci;
            else if ((day >= 21 && m == 6) || (day <= 22 && m == 7))
                return Chat.Properties.Resources.rak;
            else if ((day >= 23 && m == 7) || (day <= 22 && m == 8))
                return Chat.Properties.Resources.lav;
            else if ((day >= 23 && m == 8) || (day <= 22 && m == 9))
                return Chat.Properties.Resources.devica;
            else if ((day >= 23 && m == 9) || (day <= 22 && m == 10))
                return Chat.Properties.Resources.vaga;
            else if ((day >= 23 && m == 10) || (day <= 21 && m == 11))
                return Chat.Properties.Resources.skorpija;
            else if ((day >= 22 && m == 11) || (day <= 21 && m == 12))
                return Chat.Properties.Resources.strelec;
            else
                return Chat.Properties.Resources.jarec;
        }


        private void about_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            about.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            about.ReadOnly = true;
            btnSave.Visible = false;
        }
    }
}
