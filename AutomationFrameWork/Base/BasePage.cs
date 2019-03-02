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
        public RemoteWebDriver Driver { get; set; }
        public BasePage(RemoteWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}
