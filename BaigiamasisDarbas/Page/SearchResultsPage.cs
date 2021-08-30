using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class SearchResultsPage : BasePage
    {
        public SearchResultsPage(IWebDriver webDriver) : base(webDriver) { }
        private IWebElement ResultCountNumber => Driver.FindElement(By.XPath("//span[@class= 'ks-mobile-menu-title sn-topBar-title']/span[2]"));


        public string GetResultNumber()
        {
            return ResultCountNumber.Text;
        }
    }



}

