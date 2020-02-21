using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using LiteCart;
using System.Threading;

namespace LiteCart
{
    class CheckLiteCartLink
    {
        [TestFixture]
        public class Test
        {
            private IWebDriver driver;
            private WebDriverWait wait;
            private AuthPage authPage;


            [SetUp]
            public void Start()
            {
                driver = new ChromeDriver();
                authPage = new AuthPage(driver);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            }

            [Test]
            [Obsolete]
            public void GetCheckLiteCartLink()
            {
                authPage.GoToUrl();
                authPage.ArtLink().Click();
                driver.Url.Equals("http://localhost/litecart/");
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
