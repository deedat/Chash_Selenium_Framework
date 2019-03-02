using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationFrameWork.Base
{
    public class DriverContext
    {
        // since the driver is the same betwwen all the page, then we declared it as static
        public static RemoteWebDriver OneGlobalDriver { get; set; }
        


    }
}
