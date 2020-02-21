using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using LiteCart;
using System.Threading;

namespace LiteCart
{
    class TestInputFields
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

            [TestCase("Z")]
            [TestCase("z")]
            [TestCase("Я")]
            [TestCase("я")]
            [TestCase("!")]
            [TestCase("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop")]
            [TestCase(" ")]
            [TestCase("1")]
            
            public void TestInputUsername(string a)
            {
                authPage.GoToUrl();
                authPage.SetLogin(a);
            }

            [TestCase("Z")]
            [TestCase("z")]
            [TestCase("Я")]
            [TestCase("я")]
            [TestCase("!")]
            [TestCase("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop")]
            [TestCase(" ")]
            [TestCase("1")]
            public void TestInputPassword(string a)
            {
                authPage.GoToUrl();
                authPage.SetPassword(a);
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
