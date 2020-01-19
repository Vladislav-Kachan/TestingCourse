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
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            //Assert.AreEqual("check", mainPage.getCompleteOrder());

        }

        [Test]
        public void TrueRouteDate()
        {
            SearchPage searchPage = new MainPage(Driver).FindLada();
            Assert.AreEqual("Результаты поиска для: Lada", searchPage.getFirstLada());
        }



        [Test]
        public void OrderForLongTime()
        {
            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            InvalidDataCreater orderInfoInvalid = new InvalidDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .ClickFirstCar()
                .InputRentInformation(orderInfoNormal.FirstName, orderInfoNormal.MobilePhone, orderInfoNormal.MailAdress)
                .InputDataOrder(orderInfoInvalid.StartOrder, orderInfoInvalid.EndOrder);
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            //Assert.AreEqual("check\r\nВаше сообщение отправлено!", mainPage.getCompleteOrder());
        }

        [Test]
        public void InvalidPhoneNumber()
        {
            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            InvalidDataCreater orderInfoInvalid = new InvalidDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .ClickFirstCar()
                .InputRentInformation(orderInfoNormal.FirstName, orderInfoInvalid.MobilePhone, orderInfoNormal.MailAdress)
                .InputDataOrder(orderInfoNormal.StartOrder, orderInfoNormal.EndOrder);
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            //Assert.AreEqual("check\r\nВаше сообщение отправлено!", mainPage.getCompleteOrder());

        }

        public void OrderWithoutNameAndPhone()
        {
            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .ClickFirstCar()
                .InputRentInformation("", "", orderInfoNormal.MailAdress)
                .InputDataOrder(orderInfoNormal.StartOrder, orderInfoNormal.EndOrder);
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            //Assert.AreEqual("check\r\nВаше сообщение отправлено!", mainPage.getCompleteOrder());

        }

        [Test]
        public void InvalidAdess()
        {
            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            InvalidDataCreater orderInfoInvalid = new InvalidDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .ClickFirstCar()
                .InputRentInformation(orderInfoNormal.FirstName, orderInfoNormal.MobilePhone, orderInfoNormal.MailAdress)
                .InputAdress(orderInfoInvalid.Adress)
                .InputDataOrder(orderInfoNormal.StartOrder, orderInfoNormal.EndOrder);
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            // Assert.AreEqual("check", mainPage.getCompleteOrder());

        }

        [Test]
        public void OrderWhithDriver()
        {
            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .AuthoWithDriver()
                .ClickFirstCar()
                .InputRentInformation(orderInfoNormal.FirstName, orderInfoNormal.MobilePhone, orderInfoNormal.MailAdress)
                .InputDataOrder(orderInfoNormal.StartOrder, orderInfoNormal.EndOrder);
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            //Assert.AreEqual("check\r\nВаше сообщение отправлено!", mainPage.getCompleteOrder());

        }

        [Test]
        public void AddWithOption()
        {
            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .ClickFirstCar()
                .AddOption()
                .InputRentInformation(orderInfoNormal.FirstName, orderInfoNormal.MobilePhone, orderInfoNormal.MailAdress)
                .InputDataOrder(orderInfoNormal.StartOrder, orderInfoNormal.EndOrder);
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            // Assert.AreEqual("check\r\nВаше сообщение отправлено!", mainPage.getCompleteOrder());

        }

        [Test]
        public void OrderWithAviaTicket()
        {

            NormalDataCreater orderInfoNormal = new NormalDataCreater();
            OrderCarPage mainPage = new MainPage(Driver)
                .ClickFirstCar()
                .AddAviaPhoto()
                .InputRentInformation(orderInfoNormal.FirstName, orderInfoNormal.MobilePhone, orderInfoNormal.MailAdress)
                .InputDataOrder(orderInfoNormal.StartOrder, orderInfoNormal.EndOrder);
            Assert.IsTrue(mainPage.getCompleteOrder().StartsWith("check"));
            // Assert.AreEqual("check\r\nВаше сообщение отправлено!", mainPage.getCompleteOrder());

        }

        [Test]
        public void EqualsAdressFirm()
        {
            ContactsPage mainPage = new MainPage(Driver).OpenContacts();
            Assert.IsTrue(mainPage.EqualsAdress());
        }


    }
}
