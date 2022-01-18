using EAAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace EAAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        string Url = "http://eaapp.somee.com/";
        private IWebDriver Driver;

        [TestMethod]
        public void TestMethod1()
        {
            
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(Url);
            Login();

        }
        public void Login() {

            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LnkLogin.Click();
            loginPage.TxtUserName.SendKeys("admin");
            loginPage.TxtPassword.SendKeys("password");
            loginPage.BtnLogin.Click();
        }
    }
}
