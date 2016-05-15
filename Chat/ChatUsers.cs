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
    public partial class ChatUsers : Form
    {
        public User active;
        public User selected;
        static public Dictionary<string, User> users;
        public List<User> list;

        public ChatUsers()
        {
            InitializeComponent();
        }

        public ChatUsers(User u, Dictionary<string, User> all)
        {
            active = u;
            users = all;
            list = new List<User>();
            InitializeComponent();
        }

        private void ChatUsers_Load(object sender, EventArgs e)
        {
            Load_Users();
            toolTip1.SetToolTip(btnBack, "Back to your profile ");
            toolTip1.SetToolTip(btnSend, "Send your message ");
        }

        public void Load_Users()
        {
            lstUsers.Items.Clear();
            foreach (User u in users.Values)
                if (u != active)
                    lstUsers.Items.Add(u.ToString());
            for (int i = 0; i < lstUsers.Items.Count; i++)
                if (i % 2 == 0) lstUsers.Items[i].ForeColor = Color.DarkBlue;
                else lstUsers.Items[i].ForeColor = Color.DodgerBlue;
            list = users.Values.OrderBy(o => o.fullname).ToList();
            list.Remove(active);
            lblActiveUser.Text = active.fullname;
        }

        public void Load_Messages()
        {
            lstMessages.Items.Clear();
            
            /* debugging
            foreach (User u in list)
                if(u!=active)
                lstMessages.Items.Add(u.ToString());
             */

            llblName.Text = selected.fullname.ToString();

            List<Message> inbox = new List<Message>();
            if (active.inbox.TryGetValue(selected.username, out inbox))
                foreach (Message m in inbox)
                    lstMessages.Items.Add(m.ToString());
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMessages.Visible = true;
            txtChat.Visible = true;
            btnSend.Visible = true;
            llblName.Visible = true;
            toolTip1.SetToolTip(btnSend, "Send your message");
            toolTip1.SetToolTip(btnBack, "Back to your profile");

            int select = 0;

            foreach (int index in lstUsers.SelectedIndices)
                select = index;

            selected = list[select];

            Load_Messages();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lstMessages.Items.Add(txtChat.Text);
            txtChat.Clear();
            List<Message> inbox = new List<Message>();
            if (active.inbox.TryGetValue(selected.username, out inbox))
            {
                string[] n = active.fullname.Split(' ');
                Message msg = new Message(n[0], txtChat.Text);
                if (users.TryGetValue(selected.username, out selected))
                    selected.AddMessage(active, msg);
                if (users.TryGetValue(active.username, out active))
                    active.AddMessage(selected, msg);
            }
            Load_Messages();
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profil = new Profile(Profile.active, Profile.users, true);
            profil.Show();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void lstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMessages.SelectedIndices.Clear();
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

        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Profile friend = new Profile(selected, Form1.users, false);
            friend.Show();
        }
    }
}
