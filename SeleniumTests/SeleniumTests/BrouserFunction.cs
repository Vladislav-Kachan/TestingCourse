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
