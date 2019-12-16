using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.PageObject
{
    class SearchPage
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = @"//h1[@class='entry-title']")]
        private IWebElement firstLada;
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public string getFirstLada() { return firstLada.Text; }
    }
}
