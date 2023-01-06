using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    public class CalenderHandling
    {
        String test_url = "https://www.ixigo.com/flights";
        IWebDriver driver;

        public CalenderHandling()
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
            driver.FindElement(By.XPath("//div[@class='c-input-cntr']//input[@placeholder='Depart']")).Click();
            

            while (true)
            {
                String monthtext = driver.FindElement(By.XPath("(//div[@class='rd-month-label'])[1]")).Text;
                String[] sep = monthtext.Split(" ");
                if (sep[0].Equals("April"))
                    break;
                else
                    driver.FindElement(By.XPath("//button[@class=\"ixi-icon-arrow rd-next\"]")).Click();
            }




        }

    }
}