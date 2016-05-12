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
        Dictionary<string, User> users;

        public ChatUsers()
        {
            InitializeComponent();
        }

        public ChatUsers(Dictionary<string, User> u)
        {
            users = u;
            InitializeComponent();
        }

        private void ChatUsers_Load(object sender, EventArgs e)
        {
            foreach (User u in users.Values)
                lstUsers.Items.Add(u.fullname);
            for (int i = 0; i < lstUsers.Items.Count; i++)
                if (i % 2 == 0) lstUsers.Items[i].ForeColor = Color.DarkBlue;
                else lstUsers.Items[i].ForeColor = Color.DodgerBlue;
        }
    }
}
