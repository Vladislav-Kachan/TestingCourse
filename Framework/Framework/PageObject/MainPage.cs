﻿using System;
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
    class MainPage
    {
        IWebDriver driver;

        static private ILog Log = LogManager.GetLogger(typeof(Logger));


        [FindsBy(How = How.XPath, Using = @"/html/body/main/div/div[1]/div/div/section[5]/div/div/div/div/div/div[4]/div/div/div/div[1]/div/div/div/section[2]/div/div/div/div/div/div[1]/div/div/a")]
        private IWebElement FirstCar;

        [FindsBy(How = How.XPath, Using = @"/html/body/main/div/div[1]/div/div/section[2]/div/div/div/div/div/div[1]/div/div/div/div[1]/div/div/div/section/div/div/div/div/div/div[1]/div/div/a")]
        private IWebElement FirstCarWithDriver;

        [FindsBy(How = How.Name, Using = @"phrase")]
        private IWebElement serchbox;


        [FindsBy(How = How.XPath, Using = @"/html/body/main/div/div[1]/div/div/section/div/div/div[1]/div/div/div/div/div/p[1]/br[1]")]
        private IWebElement adressFirm;


        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
            
        }

        public SearchPage FindLada()
        {
            serchbox.SendKeys("Lada" + Keys.Enter);
            Log.Info("FindCar");
            return new SearchPage(driver);
        }

        public MainPage AuthoWithDriver()
        {
            driver.Navigate().GoToUrl("https://car-rent.by/katalog/arenda-avto-s-voditelem/");
            Log.Info("Chose autho with driver");
            return this;
        }

        public OrderCarPage ClickFirstCarWithDriver()
        {
            FirstCarWithDriver.Click();
            Log.Info("Click First Car");
            return new OrderCarPage(driver);
        }

        public OrderCarPage ClickFirstCar()
        {
            FirstCar.Click();
            Log.Info("Click First Car");
            return new OrderCarPage(driver);
        }

        public ContactsPage OpenContacts()
        {
            driver.Navigate().GoToUrl("https://car-rent.by/kontakty/");
            Log.Info("Open Contacts");
            return new ContactsPage(driver, adressFirm.ToString());
        }

    }
}
