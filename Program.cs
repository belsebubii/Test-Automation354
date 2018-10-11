using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.plusplaner.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("Username")).SendKeys("user21");
            driver.FindElement(By.Id("password")).SendKeys("Pass21" + Keys.Enter);
        }
    }
}
