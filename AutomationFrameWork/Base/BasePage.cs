using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFrameWork.Base
{
    public abstract class BasePage 
    {
        
        // public RemoteWebDriver DriverOfThisPage { get; set; }
        public BasePage()
        {
           //  this.DriverOfThisPage = DriverContext.OneGlobalDriver;
        }
    }
}
