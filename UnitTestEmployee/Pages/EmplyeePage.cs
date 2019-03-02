using AutomationFrameWork.Base;
using OpenQA.Selenium;

namespace UnitTestEmployee.Pages
{
    class EmplyeePage
    {
        public IWebElement TxtSearch => DriverContext.OneGlobalDriver.FindElement(By.Name("searchTerm"));
        public IWebElement LinkClickNew => DriverContext.OneGlobalDriver.FindElement(By.XPath("/html/body/div[2]/form/a"));

         public void ClickCreateNew()
        {
            LinkClickNew.Click();

        }
    }
}
