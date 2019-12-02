using System;
using System.IO;
using GitHubAutomation.Tests;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace Framework.Tests
{
    class Tests:TestConfig
    {
        [Test]
       
        public void FindTicketWithoutIndicateSeat()
        {
            MakeScreenshotWhenFail(() =>
            {
                OrderCarPage mainPage = new MainPage(Driver)
                        .ClickFirstCar()
                        .InputRentInformation(UsersCreator.WithAllProperties(),DateOrderCreater.WithAllProperties());
               Assert.AreEqual("check\r\nВаше сообщение отправлено!", mainPage.getCompleteOrder());

            });           
        }

        [Test]        
        public void TrueRouteDate()
        {
            SearchPage searchPage = new MainPage(Driver).FindLada();
            Assert.AreEqual("Результаты поиска для: Lada", searchPage.getFirstLada());
        }
    }
}
