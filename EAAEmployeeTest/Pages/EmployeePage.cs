using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAEmployeeTest.Pages
{
    class EmployeePage
    {
        private IWebDriver _driver;
        public EmployeePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement LnkLogin => _driver.FindElement(By.LinkText("Login"));
    }
}
