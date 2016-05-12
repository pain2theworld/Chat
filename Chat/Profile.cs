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
        string datum;
        public Dictionary<int, Image> avatar;
        public Profile()
        {
            avatar = new Dictionary<int, Image>();
            avatar.Add(1, Chat.Properties.Resources.f_3);
            InitializeComponent();
            pictureBox1.Image = avatar[1];
            toolTip1.SetToolTip(game, "You can play game");
            toolTip1.SetToolTip(friends, "See your friends");
            toolTip1.SetToolTip(imgLogOff, "Sign Out");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LettersGame igra = new LettersGame();
            igra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatUsers friends = new ChatUsers();
            friends.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 odjava = new Form1();
            odjava.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            //
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //lbl.Text = monthCalendar1.ToString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            datum = e.Start.ToShortDateString();
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
