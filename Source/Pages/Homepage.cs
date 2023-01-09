using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Source.Pages
{
    public class Homepage
    {
        IWebDriver _driver;

        [FindsBy(How = How.Id,Using = "twotabsearchtextbox")]
        IWebElement _searchtxtbox;
        [FindsBy(How = How.Id,Using = "nav-search-submit-button")]
        IWebElement _searchButton;
        public Homepage(IWebDriver driver) 
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public void search(string searchtext)
        {
            _searchtxtbox.SendKeys(searchtext);
            _searchButton.Click();

        }
    }
}
