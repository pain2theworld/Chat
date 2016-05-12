using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chat
{
    public enum gender
    {
        male,
        female
    }

    public class User
    {
        public string username { get; set; }
        public string fullname { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string dateBirth { get; set; }
        public string description { get; set; }
        public Image avatar { get; set; }
        public List<Message> inbox;

        public User (string u, string f, string p, string e, string g, string db, string desc)
        {
            username = u;
            fullname = f;
            password = p;
            email = e;
            gender = g;
            dateBirth = db;
            description = desc;
            inbox = new List<Message>();
        }

        public void AddMessage(Message m)
        {
            inbox.Add(m);
        }

        public void ChangeAvatar(Image i)
        {
            avatar = i;
        }
    }
}
