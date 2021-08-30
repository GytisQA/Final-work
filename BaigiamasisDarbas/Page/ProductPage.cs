using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    class ProductPage : BasePage
    {
        private IWebElement FindElementToGoToCart => Driver.FindElement(By.XPath("//a[text()='Peržiūrėti pirkinių krepšelį']"));
        private IWebElement FindAddonButton => Driver.FindElement(By.ClassName("c-button-inverse"));
        private IWebElement FindLikeElement => Driver.FindElement(By.CssSelector("div.add-favorite-wrap > a"));
        private IWebElement FindKartElement => Driver.FindElement(By.Id("add_to_cart_btn"));

        public ProductPage(IWebDriver webDriver) : base(webDriver) { }

        public void GetProduct(string productUrl)
        {
            Driver.Navigate().GoToUrl($"https://www.senukai.lt/p/{productUrl}");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        public void LikeProduct()
        {
            FindLikeElement.Click();
        }
        public void AddToKart()
        {
            FindKartElement.Click();
        }
        public void CloseAddon()
        {
            FindAddonButton.Click();
        }
        public void GoToCartPage()
        {
            FindElementToGoToCart.Click();
        }
    }

}

