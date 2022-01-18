using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAAutoFramework.Base
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
       // public IWebElement LnkLogin => _driver.FindElement(By.LinkText("Login"));

    }
}
