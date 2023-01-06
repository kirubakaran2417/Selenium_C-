using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    public class WindowHandling
    {
        String test_url = "https://demo.automationtesting.in/Windows.html";
        IWebDriver driver;

        public WindowHandling()
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
            driver.FindElement(By.XPath("//a[@href=\"#Seperate\"]")).Click();
            driver.FindElement(By.XPath("//div[@id='Seperate']//button")).Click();

            List<String> windows=driver.WindowHandles.ToList();
            Debug.WriteLine(windows.Count);

            driver.SwitchTo().Window(windows[1]);
            Debug.WriteLine(driver.Title);
            driver.FindElement(By.XPath("//a[@href='/downloads']")).Click();
            driver.Close();

            driver.SwitchTo().Window(windows[0]);








        }

    }
}