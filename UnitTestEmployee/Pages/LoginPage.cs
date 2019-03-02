using AutomationFrameWork.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestEmployee.Pages
{
    class LoginPage:BasePage
    {
        
        
        public LoginPage(RemoteWebDriver driver):base(driver)
        {
             
        }

        public IWebElement LinkLogin => Driver.FindElement(By.Id("loginLink"));
        public IWebElement TxtUserName => Driver.FindElement(By.Id("UserName"));
        public IWebElement TxtPassword => Driver.FindElement(By.Id("Password"));
        public IWebElement BtnSubmit => Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input"));

        //[FindsBy(How = How.Id, Using = "loginLink")]
        //public IWebElement LinkLogin { get; set; }
        //
        //[FindsBy(How = How.Id, Using = "UserName")]
        //public IWebElement TxtUserName { get; set; }
        //
        //[FindsBy(How = How.Id, Using = "Password")]
        //public IWebElement TxtPassword { get; set; }
        //
        //[FindsBy(How = How.XPath, Using = "//*[@id=\"loginForm\"]/form/div[4]/div/input")]
        //public IWebElement BtnSubmit { get; set; }

    }
}
