using GitHubAutomation.Services;
using System;
using System.Collections.Generic;
using System.Text;
using GitHubAutomation.Models;

namespace GitHubAutomation.Services
{
    class UsersCreator
    {
        public static Users WithAllProperties()
        {
            return new Users(TestDataReader.GetData("FirstName"), TestDataReader.GetData("MobilePhone"), TestDataReader.GetData("MailAdress"));
        }
    }
}
