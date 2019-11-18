using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObject.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject
{
    [TestClass]
    public class Test
    {
        IWebDriver Browser;
        private static string HomePage = "https://car-rent.by/";

        [TestMethod]
        public void InvalidOrderDate()
        {
            Browser = new ChromeDriver();
            Browser.Navigate().GoToUrl(HomePage);

            MainPage mainPage = new MainPage(Browser).ClickFirstCar();       

            OrderCarPage orderCarPage = new OrderCarPage(Browser)
                .InputRentInformation("vlad", "-3751111111", "somemail@mail.ru");

            Assert.AreEqual("check\r\nВаше сообщение отправлено!", orderCarPage.completeOrder.Text);
            Browser.Quit();
        }

        [TestMethod]
        public void InvalidAdress()
        {
            Browser = new ChromeDriver();
            Browser.Navigate().GoToUrl(HomePage);

            MainPage mainPage = new MainPage(Browser).ClickFirstCar();

            OrderCarPage orderCarPage = new OrderCarPage(Browser)
                .InputAdress("Улица Пушкина дом Калатушкина")
                .InputRentInformation("vlad", "-3751111111", "somemail@mail.ru");


            Assert.AreEqual("check\r\nВаше сообщение отправлено!", orderCarPage.completeOrder.Text);
        }
    }
}
