using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Diagnostics;
using System.Xml;

namespace TestProject1
{

    [TestClass]
    public class Datadriventesting
    {
        //Redirecting to the url and validate whether it landed on respective page
        [TestMethod]
        [DataRow("steven","rogers","01/02/2023")]
        [DataRow("peter", "parker", "02/02/2023")]
        [DataRow("Natasha", "Romanov","02/02/2023")]

        public void DatadriventestingusingDataRow(String fName,String lName,String eDate)
        {
        //for opening the browser
            String test_url = "http://uitestpractice.com/Students/Create";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("FirstName")).SendKeys(fName);
            driver.FindElement(By.Id("LastName")).SendKeys(lName);
            driver.FindElement(By.Id("EnrollmentDate")).SendKeys(eDate);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();   
                      

            driver.Quit();

        }
        [DynamicData(nameof(GetData),DynamicDataSourceType.Method)]
        [TestMethod]
        public void DatadriventestingusingDynamicDataAttribute(String fName, String lName, String eDate)
        {
            //for opening the browser
            String test_url = "http://uitestpractice.com/Students/Create";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("FirstName")).SendKeys(fName);
            driver.FindElement(By.Id("LastName")).SendKeys(lName);
            driver.FindElement(By.Id("EnrollmentDate")).SendKeys(eDate);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            driver.Quit();
        }
        [DynamicData(nameof(ReadExcel), DynamicDataSourceType.Method)]
        [TestMethod]
        public void DatadriventestingusingExcelSheet(String fName, String lName, String eDate)
        {
            //for opening the browser
            String test_url = "http://uitestpractice.com/Students/Create";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("FirstName")).SendKeys(fName);
            driver.FindElement(By.Id("LastName")).SendKeys(lName);
            driver.FindElement(By.Id("EnrollmentDate")).SendKeys(eDate);
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            driver.Quit();
        }
        public static IEnumerable<object[]> ReadExcel() {
            //create worksheet object
            using (ExcelPackage package = new ExcelPackage(new FileInfo("Data.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.End.Row;
                for(int i=2;i<=rowCount;i++)
                {
                    yield return new object[]
                    {
                        worksheet.Cells[i,1].Value?.ToString().Trim(),//Firstname
                        worksheet.Cells[i,2].Value?.ToString().Trim(),//lastname
                        worksheet.Cells[i,3].Value?.ToString().Trim() //enrollmentdate
                    };
                }
            }
        }

        public static IEnumerable<Object[]> GetData()
        {
            //keeps track  of which record it has returned and next time next day data it goes on as long as how many data are there
            yield return new object[] { "steven", "rogers", "01/02/2023" };
            yield return new object[] { "peter", "parker", "02/02/2023" };
            yield return new object[] { "Natasha", "Romanov", "02/02/2023" };
        }
    }
}