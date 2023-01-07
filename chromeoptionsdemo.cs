using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    public class chromeoptionsdemo
    {
       
       
        [TestMethod]
        public void TestMethod1()
        {
            string url = "https://www.google.com";
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() { "incognito" });
            /*
             * start-maximized
             * incognito
             * headless
             * disable-extensions
             * disable-infobars
             * disable-notifications
             * version
             * disable-popup-blocking
             */
            var chromeDriverService=ChromeDriverService.CreateDefaultService();
            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl(url);
            string title = driver.Title;
            Debug.WriteLine(title);
        }

    }
}