using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using Framework.PageObject;
using Framework.Test;
using Framework.Service;
using Framework.Models;
using log4net;

namespace Framework.Test
{
    class Tests : TestConfig
    {

        [Test]
        public void RetroactivelyRent()
        {
            InvalidDataCreater orderInfoInvalid = new InvalidDataCreater();
            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .ClickFirstCar()
                .InputRentInformation(orderInfoNormal.FirstName, orderInfoNormal.MobilePhone, orderInfoNormal.MailAdress)
                .InputDataOrder(orderInfoInvalid.StartOrder, orderInfoInvalid.EndOrder);
            Assert.AreEqual("check", mainPage.getCompleteOrder());

        }

    }
}
