using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;

namespace PageObject
{
    [TestClass]
    public class Test
    {
        private IWebDriver Browser;
        private static string HomePage = "https://car-rent.by/";

        public class personalInfo
        {
            public string firstName = "Vlad";
            public string mobileNumber = "-3751111111";
            public string mail = "somemail@mail.ru";
        }

        public personalInfo Person = new personalInfo();

        [SetUp]
        public void OpenBrouserWithSite()
        {
            Browser = new ChromeDriver();
            Browser.Navigate().GoToUrl(HomePage);
            
        }

        [TearDown]
        public void CloseBrouser()
        {
            Browser.Quit();
        }

        [TestMethod]
        public void InvalidOrderDate()
        {
            OpenBrouserWithSite();
            MainPage mainPage = new MainPage(Browser).ClickFirstCar();       

            OrderCarPage orderCarPage = new OrderCarPage(Browser)
                .InputRentInformation(Person);

            NUnit.Framework.Assert.AreEqual("check\r\nВаше сообщение отправлено!", orderCarPage.GetOrderStatus());
            CloseBrouser();
        }

        [TestMethod]
        public void InvalidAdress()
        {
            OpenBrouserWithSite();
            MainPage mainPage = new MainPage(Browser).ClickFirstCar();            

            OrderCarPage orderCarPage = new OrderCarPage(Browser)
                .InputAdress("Улица Пушкина дом Калатушкина")
                .InputRentInformation(Person);

            NUnit.Framework.Assert.AreEqual("check\r\nВаше сообщение отправлено!", orderCarPage.GetOrderStatus());
            CloseBrouser();
        }
    }
}
