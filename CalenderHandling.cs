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
          //driver.Manage().Timeouts().PageLoad=TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[@class='c-input-cntr']//input[@placeholder='Depart']")).Click();
            
            //Explicit wait
            WebDriverWait wait=new WebDriverWait(driver,TimeSpan.FromSeconds(15));
            IWebElement Searchresult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementToBeClickable(By.XPath("")));

            //fluent wait
            DefaultWait<IWebDriver> fluentwait = new DefaultWait<IWebDriver>(driver);
            fluentwait.Timeout=TimeSpan.FromSeconds(15);

            fluentwait.PollingInterval = TimeSpan.FromMilliseconds(5000);
            fluentwait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentwait.Message = "Element to be searched not found";
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