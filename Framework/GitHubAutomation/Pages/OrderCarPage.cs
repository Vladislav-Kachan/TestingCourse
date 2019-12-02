using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubAutomation.Models;


namespace GitHubAutomation.Pages
{
    class OrderCarPage
    {
        IWebDriver driver;

        [FindsBy(How = How.Name, Using = "field1")]
        private IWebElement beginRent;

        [FindsBy(How = How.Name, Using = "field2")]
        private IWebElement endRent;

        [FindsBy(How = How.Name, Using = "field7[]")]
        private IWebElement firstName;

        [FindsBy(How = How.Name, Using = "field9[]")]
        private IWebElement phoneNumber;

        [FindsBy(How = How.Name, Using = "field8")]
        private IWebElement adresMail;

        [FindsBy(How = How.XPath, Using = @"//button[@class='button submit-button']")]
        private IWebElement orderButton;

        [FindsBy(How = How.XPath, Using = @"//div[@class='final-success']")]
        private IWebElement completeOrder { get; set; }

        public OrderCarPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        public OrderCarPage InputRentInformation(Users user,DateOrder dateOrder)
        {
            firstName.SendKeys(user.getFirstName());
            phoneNumber.SendKeys(user.getMobilePhone());
            adresMail.SendKeys(user.getMailAdress());
            beginRent.SendKeys(dateOrder.getStartOrder());
            endRent.SendKeys(dateOrder.getEndOrder());
            orderButton.Click();
            return this;
        }

        public string getCompleteOrder() { return completeOrder.Text; }

    }
}
