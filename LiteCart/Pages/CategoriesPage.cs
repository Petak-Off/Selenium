using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LiteCart.Pages
{
     public class CategoriesPage
     {
        private IWebDriver driver;
        private WebDriverWait wait;

        public CategoriesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToUrl()
        {
            driver.Url = "http://localhost/litecart/rubber-ducks-c-1/";
        }

        public IWebElement ProductYellowDuck()
        {
            return driver.FindElement(By.CssSelector("[href*='http://localhost/litecart/rubber-ducks-c-1/yellow-duck-p-1']"));
        }
     }
}
