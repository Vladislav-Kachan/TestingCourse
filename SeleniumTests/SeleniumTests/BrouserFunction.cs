using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public abstract class BrouserFunction
    {
        public IWebDriver webDriver;

        [SetUp]
        public void OpenBrouserWithSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("https://car-rent.by/");
            var ImageCar = GetWebElementByXPath("//div[@class='elementor-element elementor-element-693b434 elementor-widget elementor-widget-image']");
            ImageCar.Click();
            var NameField = GetWebElementByName("field7[]");
            var PhoneField = GetWebElementByName("field9[]");
            var MailField = GetWebElementByName("field8");
            NameField.SendKeys("Vadim");
            PhoneField.SendKeys("-3751111111");
            MailField.SendKeys("test@mail.ru");
        }
        
        [TearDown]
        public void CloseBrouser()
        {
            webDriver.Quit();
        }

        protected IWebElement GetWebElementByXPath(string xPath)
        {
            return webDriver.FindElement(By.XPath(xPath));
        }

        protected IWebElement GetWebElementByName(string name)
        {
            return webDriver.FindElement(By.Name(name));
        }
    }
    
}
