using System;
using Framework.Service;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.Models
{
    public class NormalDataCreater
    {
        public string FirstName;
        public string MobilePhone;
        public string MailAdress;
        public string StartOrder;
        public string EndOrder;

        public NormalDataCreater()
        {
            FirstName = NormalDataReader.GetData("FirstName");
            MobilePhone = NormalDataReader.GetData("MobilePhone");
            MailAdress = NormalDataReader.GetData("MailAdress");
            StartOrder = NormalDataReader.GetData("StartOrder");
            EndOrder = NormalDataReader.GetData("EndOrder");
        }
    }
}
