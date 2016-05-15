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
        public string avatar { get; set; }
        public Dictionary<string, List<Message>> inbox;

        public User(string u, string f, string p, string e, string g, string db, string desc)
        {
            username = u;
            fullname = f;
            password = p;
            email = e;
            gender = g;
            dateBirth = db;
            description = desc;
            avatar = " ";
            inbox = new Dictionary<string, List<Message>>();
        }

        public void AddMessage(User u, Message m)
        {
            List<Message> existent;
            if (!inbox.ContainsKey(u.username))
                inbox.Add(u.username, new List<Message>());
            if (inbox.TryGetValue(u.username, out existent))
                existent.Add(m);
        }

        public void ChangeAvatar(string i)
        {
            avatar = i;
        }

        public override string ToString()
        {
            return fullname;
        }
    }
}
