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

    class LoginPage : BasePage
    {


        public LoginPage()
        {

        }
        // insted of using "DriverOfThisPage" which in comment in BasePage class, we use "DriverContext.OneGlobalDriver"
        public IWebElement LinkLogin => DriverContext.OneGlobalDriver.FindElement(By.Id("loginLink"));

        public IWebElement TxtUserName => DriverContext.OneGlobalDriver.FindElement(By.Id("UserName"));


        public IWebElement TxtPassword => DriverContext.OneGlobalDriver.FindElement(By.Id("Password"));

        public IWebElement BtnSubmit => DriverContext.OneGlobalDriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input"));

        public IWebElement LinkEmployeeList => DriverContext.OneGlobalDriver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/ul/li[3]/a"));
        public IWebElement TxtSearchTerm => DriverContext.OneGlobalDriver.FindElement(By.Name("searchTerm"));




        public void ClickLoginLink()
        {
            LinkLogin.Click();
        }

        public void Login(string usrname, string password)
        {
            TxtUserName.SendKeys(usrname);
            TxtPassword.SendKeys(password);
            TxtPassword.Submit();
        }

        public EmplyeePage ClickEmployeeList()
        {
            LinkEmployeeList.Click();
            return new EmplyeePage();
        }

        public void EnterTerm(string term)
        {
            TxtSearchTerm.SendKeys(term);
        }


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
