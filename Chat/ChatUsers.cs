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
        public Dictionary<string, User> users;
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
            users.Add("Alala", new User("Alala", "ALala La", "pas", "email", "female", "15/12/1985", "I love me."));
            users.Add("Blala", new User("Blala", "BLala La", "pas", "email", "female", "15/12/1985", "I love me."));
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

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMessages.Visible = true;
            txtChat.Visible = true;
            lstMessages.Items.Clear();

            int selected = 0;

            foreach (int index in lstUsers.SelectedIndices)
                selected = index;

            /* debugging
            foreach (User u in list)
                if(u!=active)
                lstMessages.Items.Add(u.ToString());
             */

            llblName.Text = list[selected].ToString();
            List<Message> inbox = new List<Message>();

            if (active.inbox.TryGetValue(list[selected].username, out inbox))
                foreach (Message m in inbox)
                    lstMessages.Items.Add(m.ToString());
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lstMessages.Items.Add(txtChat.Text);
            txtChat.Clear();
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend.PerformClick();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profil = new Profile(active, Form1.users);
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
    }
}
