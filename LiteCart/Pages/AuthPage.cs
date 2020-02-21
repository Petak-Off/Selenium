using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LiteCart
{
    public class AuthPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AuthPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToUrl()
        {
            driver.Url = "http://localhost/litecart/admin/";
        }

        public void SetLogin(string login)
        {
            InputUsername().SendKeys(login);
        }

        public IWebElement InputUsername()
        {
            return driver.FindElement(By.Name("username"));
        }

        public void SetPassword(string password)
        {
            InputPassword().SendKeys(password);
        }

        public IWebElement InputPassword()
        {
            return driver.FindElement(By.Name("password"));
        }


        public IWebElement CheckBoxRemmemderMe()
        {
            return driver.FindElement(By.Name("remember_me"));
        }

        public IWebElement Login()
        {
            return driver.FindElement(By.TagName("button"));
        }
        public IWebElement ArtLink()
        {
            return driver.FindElement(By.ClassName("header"));
        }
        public IWebElement AlertDanger()
        {
            return driver.FindElement(By.Id("notices"));
        }
    }
}
