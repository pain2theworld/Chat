using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    class User
    {
        private string name { get; set; }
        private string surname { get; set; }
        private string password { get; set; }
        private string description { get; set; }
        private List<Message> inbox;

        public User (string n, string s, string p, string desc)
        {
            name = n;
            surname = s;
            password = p;
            description = desc;
            inbox = new List<Message>();
        }

        public void AddMessage(Message m)
        {
            inbox.Add(m);
        }
    }
}
