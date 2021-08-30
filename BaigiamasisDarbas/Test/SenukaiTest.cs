using BaigiamasisDarbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Test
{
    public class SenukaiTest
    {
        private static SenukaiHomePage _homePage;
        private static SearchResultsPage _SearchPage;
        private static LogInPage _logInPage;
        private static ProductPage _productPage;
        private static LikedItemPage _likedItemPage;
        private static KartPage _kartPage;
        private static IWebDriver _driver;

        [SetUp]
        
        public static void SetUp()
        {

            _driver = new ChromeDriver();
            _driver.Url = "https://www.senukai.lt/";
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _homePage = new SenukaiHomePage(_driver);
            _SearchPage = new SearchResultsPage(_driver);
            _logInPage = new LogInPage(_driver);
            _productPage = new ProductPage(_driver);
            _likedItemPage = new LikedItemPage(_driver);
            _kartPage = new KartPage(_driver);
        }

        [TearDown]
        public static void OneTimeTearDown()
        {
            _driver.Quit();
        }
        //use clear
        [TestCase("Stalinis sviestuvas", "(1211)")]
        [TestCase("xxxyyy", "(0)")]
                
        public static void SearchFieldTest(string firstInput, string mainresult)
        {
            _homePage.SearchByText(firstInput);
            _homePage.PressOnSearchIcon();
            Assert.AreEqual(mainresult, _SearchPage.GetResultNumber());
            
        }
            [Test]
        public void LogIn()
        {
            _homePage.ClickLogInButton();
            _logInPage.EnterEmail("ninex44058@frnla.com");
            _logInPage.EnterPassword("barbarisas20");
            _logInPage.ClickSubmitButton();
            Assert.AreEqual("Sveiki,\r\nninex44058...", _logInPage.GetTextSveiki());
        }
        [Test]
        public void LikedItem()
        {
            LogIn();
            _productPage.GetProduct("benzininis-grandininis-pjuklas-yd-kw10-52e-375-2-0kw-45cm/d6ad?cat=66p&index=1");
            Thread.Sleep(5000);
            _productPage.LikeProduct();
            _likedItemPage.ClickWishList();
            Assert.AreEqual("Prekių: 1", _likedItemPage.GetWishlistCountText());


        }
        [Test]
        public void AddingItemToTheCart()
        {
            _productPage.GetProduct("kapsulinis-kavos-aparatas-nespresso-pixie-juodas-raudonas/d1ha?cat=9nq&index=6");
            Thread.Sleep(5000);
            _productPage.CloseAddon();
            _productPage.AddToKart();
            _productPage.GoToCartPage();
            Assert.AreEqual("Kapsulinis kavos aparatas Nespresso Pixie, juodas/raudonas", _kartPage.ItemName());
        }
    }
}
