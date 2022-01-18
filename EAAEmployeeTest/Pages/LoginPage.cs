using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace EAAEmployeeTest.Pages
{
    public class LoginPage : BasePage
        
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement LnkLogin => _driver.FindElement(By.LinkText("Login"));
        public IWebElement TxtUserName => _driver.FindElement(By.Id("UserName"));
        public IWebElement TxtPassword => _driver.FindElement(By.Id("Password"));
        public IWebElement BtnLogin => _driver.FindElement(By.XPath("//*[contains(@class, 'btn btn-default')]"));
    }
}
