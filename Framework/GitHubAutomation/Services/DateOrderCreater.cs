using GitHubAutomation.Services;
using System;
using System.Collections.Generic;
using System.Text;
using GitHubAutomation.Models;

namespace GitHubAutomation.Services
{
    class DateOrderCreater
    {
        public static DateOrder WithAllProperties()
        {
            return new DateOrder(TestDataReader.GetData("StartOrder"), TestDataReader.GetData("EndtOrder"));
        }
    }
}
