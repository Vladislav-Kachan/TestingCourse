using System;
using System.IO;
using Framework.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Framework.PageObject;
using Framework.Driver;
using NUnit.Framework.Interfaces;
using log4net;
using log4net.Config;

namespace Framework.Test
{
    public class TestConfig: Logger
    {
        static private ILog Log = LogManager.GetLogger(typeof(Logger));

        protected IWebDriver Driver { get; set; }

        
        [SetUp]
        public void Setter()
        {
            Driver = DriverSingleton.GetDriver();
            Driver.Navigate().GoToUrl("https://car-rent.by");
        }


        [TearDown]
        public void ClearDriver()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                string screenFolder = AppDomain.CurrentDomain.BaseDirectory + @"\screens";
                Directory.CreateDirectory(screenFolder);
                var screen = Driver.TakeScreenshot();
                screen.SaveAsFile(screenFolder + @"\screen" + DateTime.Now.ToString("yy-MM-dd_hh-mm-ss") + ".png",
                    ScreenshotImageFormat.Png);

                Log.Error("TestFailure");
            }
            else Log.Info("TestSuccess");


            DriverSingleton.CloseDriver();
        }
    }
}
