using Framework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Framework.Models
{
    class InvalidDataCreater
    {
        public string FirstName;
        public string MobilePhone;
        public string MailAdress;
        public string StartOrder;
        public string EndOrder;
        public string Adress;

        public InvalidDataCreater()
        {
            FirstName = InfalidDataReader.GetData("FirstName");
            MobilePhone = InfalidDataReader.GetData("MobilePhone");
            MailAdress = InfalidDataReader.GetData("MailAdress");
            StartOrder = InfalidDataReader.GetData("StartOrder");
            EndOrder = InfalidDataReader.GetData("EndOrder");
            Adress = InfalidDataReader.GetData("Adress");
        }
    }
}
