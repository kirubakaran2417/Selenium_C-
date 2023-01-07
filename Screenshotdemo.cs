using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    public class Screenshotdemo
    {
        String test_url = "https://demo.automationtesting.in/Windows.html";
        IWebDriver driver;

        public Screenshotdemo()
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
            Screenshot TakeScreenshot = ((ITakesScreenshot)driver).GetScreenshot();
            TakeScreenshot.SaveAsFile("C:\\Users\\k.kirubakaran\\source\\repos\\TestProject1\\TestProject1\\a.jpg");








        }

    }
}