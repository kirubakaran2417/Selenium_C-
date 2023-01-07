using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace TestProject1
{
    [TestClass]
    public class Readdatafrometxtfile
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            string filename = @"D:\Testdata\File.txt";
            var data = System.IO.File.ReadAllText(filename, Encoding.UTF8);
            Debug.WriteLine(data);



        }

    }
}