
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using GitHubAutomation.Pages;

namespace GitHubAutomation.Pages
{
    class MainPage
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = @"//div[@class='elementor-element elementor-element-49f983c elementor-column elementor-col-100 elementor-top-column']")]
        private IWebElement FirstCar;
        [FindsBy(How = How.Name, Using = @"phrase")]
        private IWebElement serchbox;
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        public SearchPage FindLada()
        {
            serchbox.SendKeys("Lada" + Keys.Enter);
            return new SearchPage(driver);
        }

        public OrderCarPage ClickFirstCar()
        {
            FirstCar.Click();
            return new OrderCarPage(driver);
        }
    }
}
