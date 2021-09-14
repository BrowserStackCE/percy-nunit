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

            //OpenQA.Selenium.Chrome.ChromeOptions capability = new OpenQA.Selenium.Chrome.ChromeOptions();
            //capability.AddAdditionalCapability("os_version", "10", true);
            //capability.AddAdditionalCapability("resolution", "1920x1080", true);
            //capability.AddAdditionalCapability("browser", "Chrome", true);
            //capability.AddAdditionalCapability("browser_version", "91.0", true);
            //capability.AddAdditionalCapability("os", "Windows", true);
            //capability.AddAdditionalCapability("name", "BStack-[C_sharp] Sample Test", true); // test name
            //capability.AddAdditionalCapability("build", "BStack Build Number 1", true); // CI/CD job or build name
            //capability.AddAdditionalCapability("browserstack.user", "mohammedk1", true);
            //capability.AddAdditionalCapability("browserstack.key", "spBCpUJaVTnvxxssFtEJ", true);
            //driver = new RemoteWebDriver(
            //  new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
            //);
            driver = new ChromeDriver("/Users/mohammed/Downloads");
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
            //_percy.Snapshot("HomePage", new Dictionary<string, object> { { "widths", new List<int> { 768, 992, 1200 } } });
            // _percy.Snapshot(driver, "Home Page", null);
            _percy.Snapshot(driver,"a", new Dictionary<string, object> { { "widths", new List<int> { 768, 992, 1200 } } });
            
            driver.Quit();
          
        }
    }
}
