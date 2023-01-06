using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;

namespace TestProject1
{
    [TestClass]
    public class Alertsdemo
    {
        String test_url = "https://www.mycontactform.com/samples.php";
        String expTitle = "Free Contact and Email Forms - myContactForm.com";
        IWebDriver driver;

        public Alertsdemo()
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

            IWebElement element = driver.FindElement(By.Id("q3"));
            SelectElement select = new SelectElement(element);
            select.SelectByText("Second Option");

            IWebElement check = driver.FindElement(By.XPath("//input[@value=\"Second Check Box\"]"));
            check.Click();

            IWebElement attach = driver.FindElement(By.Name("attach4589"));
            attach.SendKeys("C:\\Users\\k.kirubakaran\\Desktop\\test1.txt");


            


        }

    }
}