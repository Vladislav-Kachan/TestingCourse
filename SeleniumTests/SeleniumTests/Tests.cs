using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class Tests
    {
        public IWebDriver webDriver;

        [SetUp]
        public void OpenBrouserWithSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("https://car-rent.by/");
        }

        [TearDown]
        public void CloseBrouser()
        {
            webDriver.Quit();
        }

        [Test]
        public void OrderWithInvalidPhone()
        {
            var ImageCar = webDriver.FindElement(By.XPath("//div[@class='elementor-element elementor-element-693b434 elementor-widget elementor-widget-image']"));
            ImageCar.Click();
            var NameField = webDriver.FindElement(By.Name("field7[]"));
            var PhoneField = webDriver.FindElement(By.Name("field9[]"));
            var MailField = webDriver.FindElement(By.Name("field8"));
            NameField.SendKeys("Vadim");
            PhoneField.SendKeys("-3751111111");
            MailField.SendKeys("test@mail.ru");
            var OrderButton = webDriver.FindElement(By.XPath("//button[@class='button submit-button']"));
            OrderButton.Click();
            var CompliteOrder = webDriver.FindElement(By.XPath("//div[@class='final-success']"));
            Assert.AreEqual(CompliteOrder.Text, "check\r\nВаше сообщение отправлено!");
        }


        [Test]
        public void OrderWithPastDate()
        {
            var SearchMarka = webDriver.FindElement(By.Name("phrase"));
            SearchMarka.SendKeys("Lada"+Keys.Enter);
            var NameCar = webDriver.FindElement(By.XPath("//h2[@class='entry-title']"));            
            Assert.IsTrue(NameCar.Text.StartsWith("Lada"));            
        }
    }
}
