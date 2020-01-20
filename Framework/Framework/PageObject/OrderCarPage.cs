using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Framework.Models;
using log4net;

namespace Framework.PageObject
{
    class OrderCarPage
    {
        IWebDriver driver;

        static private ILog Log = LogManager.GetLogger(typeof(Logger));

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
        private IWebElement completeOrder;

        [FindsBy(How = How.XPath, Using = @"/html/body/div[2]/div/div/section[2]/div/div/div[1]/div/div/div[2]/div/div/div/div[2]/form/div/div/div[4]/div/div/div/div/label[3]/input")]
        private IWebElement adressCheckBox;

        [FindsBy(How = How.Name, Using = "field14[]")]
        private IWebElement adressTextInput;

        [FindsBy(How = How.XPath, Using = @"/html/body/div[2]/div/div/section[2]/div/div/div[1]/div/div/div[2]/div/div/div/div[2]/form/div/div/div[4]/div/div/div/div/label[4]/input")]
        private IWebElement navigator;

        [FindsBy(How = How.XPath, Using = @"/html/body/div[2]/div/div/section[2]/div/div/div[1]/div/div/div[2]/div/div/div/div[2]/form/div/div/div[4]/div/div/div/div/label[2]/input")]
        private IWebElement childSeat;

        [FindsBy(How = How.XPath, Using = @"/html/body/div[2]/div/div/section[2]/div/div/div[1]/div/div/div[2]/div/div/div/div[2]/form/div/div/div[4]/div/div/div/div/label[1]/input")]
        private IWebElement addPhoto;

        [FindsBy(How = How.XPath, Using = @"/html/body/div[2]/div/div/section[2]/div/div/div[1]/div/div/div[2]/div/div/div/div[2]/form/div/div/div[7]/div/div/label/div/div/input")]
        private IWebElement photoButton;

        public OrderCarPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        public OrderCarPage InputRentInformation(string name, string phone, string adress)
        {
            firstName.SendKeys(name);
            phoneNumber.SendKeys(phone);
            adresMail.SendKeys(adress);
            Log.Info("Input name,number,phone");
            return this;
        }

        public OrderCarPage InputDataOrder(string startOrder, string endOrder)
        {
            beginRent.SendKeys(startOrder);
            endRent.SendKeys(endOrder);
            orderButton.Click();
            Log.Info("Input date");
            return this;
        }

        public OrderCarPage InputAdress(string adress)
        {
            adressCheckBox.Click();
            adressTextInput.SendKeys(adress);
            Log.Info("Input adress");
            return this;
        }

        public OrderCarPage AddOption()
        {
            childSeat.Click();
            navigator.Click();
            return this;
        }

        public OrderCarPage AddAviaPhoto()
        {
            addPhoto.Click();
            photoButton.SendKeys("C:\\Users\\AngelDuhast\\Desktop\\image.png");
            return this;
        }

        public string getCompleteOrder() {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(@"//div[@class='final-success']")));            
            return completeOrder.Text; }
    }
}
