using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    class LikedItemPage : LogInPage
    {
        public LikedItemPage(IWebDriver webDriver) : base(webDriver) { }

        public IWebElement WishlistCountText => Driver.FindElement(By.CssSelector("body > div.site > div.site-center > div > div:nth-child(3) > div.site-content-main.fr > div > div > a > div.wishlist-title > p.count"));
        private IWebElement FindWishListLink => Driver.FindElement(By.ClassName("favorite-items__handle"));

        public void ClickWishList()
        {
            FindWishListLink.Click();
        }
        public string GetWishlistCountText()
        {
           return WishlistCountText.Text;
        }

    }


}
