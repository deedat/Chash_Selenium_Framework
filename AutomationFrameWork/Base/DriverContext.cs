using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationFrameWork.Base
{
    public class DriverContext
    {

        private static RemoteWebDriver _driver;

        public RemoteWebDriver Driver
        {
            get =>  _driver; 
       
            set  => _driver = value;
        }

    }
}
