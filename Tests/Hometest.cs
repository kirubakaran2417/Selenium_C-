using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Source.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1.Tests
{
    [TestClass]
    public class Hometest
    {
        IWebDriver driver;
        [TestInitialize]
        public void Setup()
        {
            //new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        [TestMethod] 
        public void SearchBook()
        {
            Homepage hp = new Homepage(driver);
            driver.Navigate().GoToUrl("https://www.amazon.com");
            hp.search("Webdriver book");
        }
        [TestCleanup] 
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
