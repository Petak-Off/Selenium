using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LiteCart.Pages
{
    class ProductPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToUrl()
        {
            driver.Url = "http://localhost/litecart/rubber-ducks-c-1/yellow-duck-p-1";
        }

        public IWebElement ButtonAddCartProduct()
        {
            return driver.FindElement(By.Name("add_cart_product"));
        }
        public void SelectSize(string yourselect)
        {
            IWebElement selectElem = driver.FindElement(By.Name("options[Size]")); // обращаемся к списку по его классу, если нет ни id, ни class, то обращайтесь по XPath или CssSelector
            SelectElement select = new SelectElement(selectElem);
            System.Collections.Generic.IList<OpenQA.Selenium.IWebElement> options = select.Options;
            select.SelectByText(yourselect);
            return;
            
        }
        public IWebElement CartProduct()
        {
            return driver.FindElement(By.Id("cart"));
        }
    }
}
