using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace TestProject1
{
    [TestClass]
    public class findelementsdemo
    {
        String test_url = "https://www.mycontactform.com";
        String expTitle = "Free Contact and Email Forms - myContactForm.com";
        IWebDriver driver;

        public findelementsdemo()
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

            List<IWebElement> links = driver.FindElements(By.TagName("a")).ToList();
            Console.WriteLine(links.Count);
            Console.ReadLine();

            List<IWebElement> checkboxes = driver.FindElements(By.XPath("//*[@type='checkbox']")).ToList();
            Console.WriteLine(checkboxes.Count);
            Console.ReadLine();

            List<IWebElement> links2 = driver.FindElements(By.XPath(" //*[@id='left_col_top']/ul/li/a")).ToList();
            //create a loop to iterate all webelements from this list 
            //try to click all the links from this list one by one

            


        }

    }
}