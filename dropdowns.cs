using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections;

namespace TestProject1
{
    [TestClass]
    public class ActionsDemo
    {
        String test_url = "https://demo.automationtesting.in/Alerts.html";
        IWebDriver driver;

        public ActionsDemo()
        {
            driver = new ChromeDriver();
        }
        //Redirecting to the url and validate whether it landed on respective page
        [TestMethod]
        public void TestMethod1()
        {
            //for opening the browser
            
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[@href='#CancelTab']")).Click();
            driver.FindElement(By.XPath("//div[@id='CancelTab']//button")).Click();

            IAlert al = driver.SwitchTo().Alert();

            al.Accept();
            //al.Dismiss();
            //al.SendKeys("test");
       







        }

    }
}