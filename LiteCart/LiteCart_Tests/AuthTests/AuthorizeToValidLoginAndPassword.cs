
using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using LiteCart;
using System.Threading;
namespace LiteCart
{
    class AuthorizeToValidLoginAndPassword
    {
       [TestFixture]
        public class Tests
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
                public void GetAuthorizeToValidLoginAndPassword()
                {
                    authPage.GoToUrl();
                    authPage.SetLogin("admin");
                    authPage.SetPassword("admin");
                    authPage.Login().Click();
                    Thread.Sleep(1500);
                    Assert.AreEqual("http://localhost/litecart/admin/", driver.Url);
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
