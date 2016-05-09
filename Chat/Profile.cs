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
        public Dictionary <int,Image> avatar;
        Random random;
        public Profile()
        {
            avatar = new Dictionary<int, Image>();
            avatar.Add(1, Chat.Properties.Resources._3);
            InitializeComponent();
            pictureBox1.Image = avatar[1];
            toolTip1.SetToolTip(game, "You can play game");
            toolTip1.SetToolTip(friends, "See your friends");
            toolTip1.SetToolTip(logoff, "Sign Out");
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            //lbl.Text = monthCalendar1.ToString();


        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           datum =e.Start.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
