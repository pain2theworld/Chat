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
    public partial class LettersGame : Form
    {


        Timer timer;
        Timer timerMove;
        LettersDoc lettersDoc;
        bool flag;

        public LettersGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            lettersDoc = new LettersDoc();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timerMove = new Timer();
            timerMove.Interval = 135;
            timerMove.Tick += timerMove_Tick;
            timer.Start();
            timerMove.Start();
            flag = true;
        }

        void timerMove_Tick(object sender, EventArgs e)
        {
            if (flag)
                lettersDoc.Move();
            Invalidate(true);
            labela.Text = string.Format("Points: {0}, Missed: {1}", lettersDoc.Points, lettersDoc.Misses);

        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (flag)
                lettersDoc.AddLetter(640, 400);
            Invalidate();
            labela.Text = string.Format("Points: {0}, Missed: {1}", lettersDoc.Points, lettersDoc.Misses);


        }


        private void LettersGame_KeyDown(object sender, KeyEventArgs e)
        {

        }



        private void LettersGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            lettersDoc.Draw(e.Graphics);
        }

        private void LettersGame_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LettersGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            lettersDoc.Hit(e.KeyChar);
            Invalidate(true);
            labela.Text = string.Format("Points: {0}, Missed: {1}", lettersDoc.Points, lettersDoc.Misses);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = false;
            float procent;
            if (lettersDoc.Points + lettersDoc.Misses > 0)

                procent = (float)lettersDoc.Points / (lettersDoc.Points + lettersDoc.Misses) * 100;
            else
                procent = 0;
            result.Text = "You hit" + "\n" + "\n" + "     " + procent + "%" + "\n" + "\n" + " of the letters!!";
            result.Visible = true;
            lettersDoc.Misses = 0;
            lettersDoc.Points = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = " ";
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profil = new Profile();
            profil.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatUsers friends = new ChatUsers();
            friends.Show();
        }
    }
}
