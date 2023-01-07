using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    public class WebtableHandling
    {

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //webpage which contains a webtable
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites");
            //xpath of the html table
            var elemTable = driver.FindElement(By.XPath("//div[@id='mw-content-text']//table[1]"));
            //Fetch all the Row of the table
            List<IWebElement> listTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            string strRowdata = "";
            //Traverse each row
            foreach(var elemTr in listTrElem)
            {
                //Fetch the columns from a particular row
                List<IWebElement> listTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if(listTdElem.Count > 0)
                {
                    //Traverse each column
                    foreach(var elemTd in listTdElem)
                    {
                        //"\t\t" is used for tab space between two text
                        strRowdata=strRowdata+ elemTd.Text+"\t\t";
                    }
                }
                else
                {
                    //To print the data into the console
                    Debug.WriteLine("This is Header row");
                    Debug.WriteLine(listTrElem[0].Text.Replace(" ", "\t\t"));
                }
                Debug.WriteLine(strRowdata);
                strRowdata = string.Empty;
            }
            Debug.WriteLine("");
        }


    }
}