using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Message
    {
        private string name { get; set; }
        private string msg { get; set; }

        public Message (string n, string m)
        {
            name = n;
            msg = m;
        }

        public override string ToString()
        {
            return String.Format(name + ": " + msg);
        }
    }
}
