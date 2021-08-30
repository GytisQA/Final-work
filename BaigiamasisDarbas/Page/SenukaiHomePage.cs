using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class SenukaiHomePage : BasePage
    {
        private IWebElement LogInSecondButton => Driver.FindElement(By.XPath("//a[text()='Prisijungti']"));
        private IWebElement LogInButton => Driver.FindElement(By.ClassName("user-block__title--strong"));
        private IWebElement searchInput => Driver.FindElement(By.Id("q"));
        private IWebElement searchIcon => Driver.FindElement(By.CssSelector("#top-search-form > div > div.main-search__submit > button > i"));
        public SenukaiHomePage(IWebDriver webDriver) : base(webDriver) { }


        public void SearchByText(string searchText)
        {
            searchInput.Clear();
            searchInput.SendKeys(searchText);

        }

        public void PressOnSearchIcon()
        {
            searchIcon.Click();
        }
        public void ClickLogInButton()
        {
            LogInButton.Click();
            LogInSecondButton.Click();
        }





    }






}
