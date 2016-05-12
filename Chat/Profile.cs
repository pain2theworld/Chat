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
    public partial class Profile : Form
    {
        Form1 f1 = new Form1();
        User active;
        Dictionary<string, User> users;
        public Dictionary<int, Image> avatar;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(User u, Dictionary<string, User> all)
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


    }
}
