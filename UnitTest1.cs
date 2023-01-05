using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        String test_url = "https://www.mycontactform.com";
        String expTitle = "Free Contact and Email Forms - myContactForm.com";
        IWebDriver driver;

        public UnitTest1()
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
            String actualTitle = driver.Title;
            Assert.AreEqual(expTitle, actualTitle);
            driver.FindElement(By.LinkText("Sample Forms")).Click();
            IWebElement subject = driver.FindElement(By.Id("subject"));
            subject.SendKeys("selenium");
            driver.FindElement(By.XPath("//input[@type='checkbox'][@value='0']")).Click();

        }
        
    }
}