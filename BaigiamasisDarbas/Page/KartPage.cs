using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    class KartPage : BasePage
    {
        public KartPage(IWebDriver webDriver) : base(webDriver) { }
        public IWebElement CartItemName => Driver.FindElement(By.ClassName("detailed-cart-item__name-link"));
        private IWebElement FindKartLink => Driver.FindElement(By.ClassName("cart-block__title--strong"));





        public void ClickKartLink()
        {
            FindKartLink.Click();
        }
        public string ItemName()
        {
            return CartItemName.Text;
        }
    }
}
