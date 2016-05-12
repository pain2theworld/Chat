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
        User active;
        Dictionary<string, User> users;

        public ChatUsers()
        {
            InitializeComponent();
        }

        public ChatUsers(User u, Dictionary<string, User> all)
        {
            active = u;
            users = all;
            InitializeComponent();
        }

        private void ChatUsers_Load(object sender, EventArgs e)
        {
            foreach (User u in users.Values)
            {
                if (u != active)
                    lstUsers.Items.Add(u.ToString());
            }
            for (int i = 0; i < lstUsers.Items.Count; i++)
                if (i % 2 == 0) lstUsers.Items[i].ForeColor = Color.DarkBlue;
                else lstUsers.Items[i].ForeColor = Color.DodgerBlue;
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChat.Visible = true;
        }
    }
}
