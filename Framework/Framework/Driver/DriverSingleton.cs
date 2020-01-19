using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using Framework.PageObject;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver Driver;

        private DriverSingleton() { }

        public static IWebDriver GetDriver()
        {
            if(null == Driver)
            {
                switch (TestContext.Parameters.Get("browser"))
                {
                    case "Edge":
                        new DriverManager().SetUpDriver(new EdgeConfig());
                        Driver = new EdgeDriver();
                        break;
                    default:
                        string chromeDriverDirectory = "D:\\git\\Framework\\Chrome\\79.0.3945.36\\X64";
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        ChromeOptions options = new ChromeOptions();
                        options.AddArgument("no-sandbox");
                        Driver = new ChromeDriver(chromeDriverDirectory, options, TimeSpan.FromMinutes(2));
                        break;
                }
                Driver.Manage().Window.Maximize();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            }
            return Driver;
        }

        public static void CloseDriver()
        {
            Driver.Quit();
            Driver = null;
        }
    }
}
