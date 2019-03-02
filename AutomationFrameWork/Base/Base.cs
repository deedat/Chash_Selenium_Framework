using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AutomationFrameWork.Base
{
    public class Base
    {
        public BasePage CurrentPage { get; set; }

        //private RemoteWebDriver _driver { get; set; }

        protected TPage GetInstance<TPage>() where TPage:BasePage, new() 
        {

            TPage pageInstance = new TPage()
            {
               // _driver = DriverContext.OneGlobalDriver
            };
            

            return pageInstance;
        }



        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }

    }
}
