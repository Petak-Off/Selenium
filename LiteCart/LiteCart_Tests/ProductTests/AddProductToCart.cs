using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using LiteCart;
using System.Threading;
using LiteCart.Pages;

namespace LiteCart.LiteCart_Tests.ProductTests
{
    class AddProductToCart
    {
        [TestFixture]
        public class Test
        {
            private IWebDriver driver;
            private WebDriverWait wait;
            private CategoriesPage categoriesPage;
            private ProductPage productPage;

            [SetUp]
            public void Start()
            {
                driver = new ChromeDriver();
                categoriesPage = new CategoriesPage(driver);
                productPage = new ProductPage(driver);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            }

            [Test]
            [Obsolete]
            public void GetAddProductToCart()
            {

                categoriesPage.GoToUrl();
                categoriesPage.ProductYellowDuck().Click();
                Thread.Sleep(1500);
                productPage.SelectSize("Small");  
                Thread.Sleep(1500);
                productPage.ButtonAddCartProduct().Click();
                Thread.Sleep(1500);
                productPage.CartProduct().Click();
                Thread.Sleep(1500);
                driver.FindElement(By.CssSelector("[href*='http://localhost/litecart/rubber-ducks-c-1/subcategory-c-2/yellow-duck-p-1']")).Click();
            }


            [TearDown]
            public void Stop()
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
