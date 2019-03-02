using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestEmployee.Pages
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "loginLink")]
        public IWebElement LinkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginForm\"]/form/div[4]/div/input")]
        public IWebElement BtnSubmit { get; set; }

    }
}
