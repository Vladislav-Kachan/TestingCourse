using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject.Page
{
    class MainPage
    {

        [FindsBy(How = How.XPath, Using = @"//div[@class='elementor-element elementor-element-693b434 elementor-widget elementor-widget-image']")]
        private IWebElement FirstCar { get; set; }

        public MainPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public MainPage ClickFirstCar()
        {            
            FirstCar.Click();
            return this;
        }

    }
}
