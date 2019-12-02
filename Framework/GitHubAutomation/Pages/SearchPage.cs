using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
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
