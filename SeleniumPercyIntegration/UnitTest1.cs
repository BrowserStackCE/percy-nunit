using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using percy_csharp_selenium;

namespace SeleniumPercyIntegration
{
    public class Tests
    {
        IWebDriver driver;
        Percy _percy;
       
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("/path/to.your/local/chromedriver");
            _percy = new Percy();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine(driver.Title);
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("BrowserStack");
            query.Submit();
            Console.WriteLine(driver.Title);

            // Taking snaphot through Percy
            _percy.Snapshot("HomePage", new Dictionary<string, object> { { "widths", new List<int> { 768, 992, 1200 } } });
            
            // Teardown
            driver.Quit();
          
        }
    }
}
