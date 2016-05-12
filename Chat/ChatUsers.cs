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
            {
                lstUsers.Items.Add(u);
            }
        }
    }
}
