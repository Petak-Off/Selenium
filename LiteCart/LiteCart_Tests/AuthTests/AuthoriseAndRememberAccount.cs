using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using LiteCart;
using System.Threading;

namespace LiteCart
{
    class AuthoriseAndRememberAccount
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
            public void GetAuthoriseAndRememberAccount()
            {
                authPage.GoToUrl();
                authPage.SetLogin("admin");
                authPage.SetPassword("admin");
                authPage.CheckBoxRemmemderMe().Click();
                authPage.Login().Click();
                Thread.Sleep(2500);
                driver.FindElement(By.CssSelector("[href*='http://localhost/litecart/admin/logout.php']")).Click();
                Assert.AreEqual("admin" , authPage.InputUsername().GetAttribute("value"));
                Assert.AreEqual("admin", authPage.InputPassword().GetAttribute("value"));

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
