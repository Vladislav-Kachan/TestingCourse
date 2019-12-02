using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using static PageObject.Test;

namespace PageObject.Page
{
    class OrderCarPage
    {
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

        [FindsBy(How = How.Name, Using = "field5[]")]
        private IList<IWebElement> checkBoxAdres;

        [FindsBy(How = How.Name, Using = "field14[]")]
        private IWebElement inputAdres;

        [FindsBy(How = How.XPath, Using = @"//button[@class='button submit-button']")]
        private IWebElement orderButton;

        [FindsBy(How = How.XPath, Using = @"//div[@class='final-success']")]
        private IWebElement completeOrder;

        private static string rentStart = "16/11/2019";
        private static string rentEnd = "20/11/2019";

        public OrderCarPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public OrderCarPage InputRentInformation(personalInfo personalInfo)
        {
            firstName.SendKeys(personalInfo.firstName);
            phoneNumber.SendKeys(personalInfo.mobileNumber);
            adresMail.SendKeys(personalInfo.mail);
            beginRent.SendKeys(rentStart);
            endRent.SendKeys(rentEnd);
            orderButton.Click();         
            
            return this;
        }

        public OrderCarPage InputAdress(string adress)
        {
            checkBoxAdres[2].Click(); //Получение чекбокса "доп. услуги" из списка чекбоксов с одинаковыми именами
            inputAdres.SendKeys(adress);            
            return this;
        }

        public string GetOrderStatus()
        {
            return completeOrder.Text;
        }

    }
}
