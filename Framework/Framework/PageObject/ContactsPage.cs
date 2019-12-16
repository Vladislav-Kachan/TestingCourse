using System;
using Framework.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.PageObject
{
    class ContactsPage
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = @"/html/body/main/div/div[1]/div/div/section/div/div/div[1]/div/div/div/div/div/p[1]/br[1]")]
        private IWebElement adressFirm;
        private string adressFromMainPage;
        public ContactsPage(IWebDriver driver, string adress)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
            adressFromMainPage = adress;
        }

        public bool EqualsAdress()
        {

            if (adressFromMainPage == adressFirm.ToString())
                return true;
            else
                return false;

        }

    }
}
