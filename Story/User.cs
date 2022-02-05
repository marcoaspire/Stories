using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story
{
    class User
    {
        private string username;
        private string mailId;
        private string password;

        public User(string username, string mailId, string password)
        {
            this.username = username;
            this.mailId = mailId;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string MailId { get => mailId; set => mailId = value; }
        public string Password { get => password; set => password = value; }

        public override bool Equals(object obj)
        {
            User user = obj as User;
            if (user.Username.Equals(this.Username) && user.Password.Equals(this.Password))
                return true;
            else
                return false;   

        }

        public override string ToString()
        {
            return String.Format("Username:\"{0}\"\nMailId:\"{1}\"\nPassword\"{2}\"\n",this.Username,MailId,Password);
        }
    }
}
