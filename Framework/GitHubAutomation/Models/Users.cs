using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Models
{
    class Users
    {
        private string FirstName { get; set; }
        private string MobilePhone { get; set; }
        private string MailAdress { get; set; }


        public Users(string FirstName, string MobilePhone, string MailAdress)
        {
            this.FirstName = FirstName;
            this.MobilePhone = MobilePhone;
            this.MailAdress = MailAdress;
        }

        public string getFirstName() { return FirstName; }
        public string getMobilePhone() { return MobilePhone; }
        public string getMailAdress() { return MailAdress; }

    }
}
