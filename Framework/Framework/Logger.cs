using log4net;
using log4net.Config;
using System;
using System.IO;
using Framework.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Framework.PageObject;
using Framework.Driver;
using NUnit.Framework.Interfaces;

namespace Framework
{
    public class Logger
    {
        static private ILog Log = LogManager.GetLogger(typeof(Logger));

        public static ILog log
        {
            get { return Log; }
        }     

    }
}
