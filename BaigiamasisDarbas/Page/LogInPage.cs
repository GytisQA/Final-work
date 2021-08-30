using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class LogInPage : BasePage
    {
        public IWebElement WordSveiki => Driver.FindElement(By.ClassName("user-block__title"));
        public IWebElement SubmitButton => Driver.FindElement(By.Name("commit"));
        public LogInPage(IWebDriver webDriver) : base(webDriver) { }
        private IWebElement EmailInputField => Driver.FindElement(By.Id("user_email"));
        private IWebElement PasswordInputField => Driver.FindElement(By.Id("user_password"));
        public void EnterEmail(string email)
        {
            EmailInputField.Clear();
            EmailInputField.SendKeys(email);
        }
        public void EnterPassword(string email)
        {
            PasswordInputField.Clear();
            PasswordInputField.SendKeys(email);
        }
        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }
        public string GetTextSveiki()
        {
            return WordSveiki.Text;
        }

    }


}
