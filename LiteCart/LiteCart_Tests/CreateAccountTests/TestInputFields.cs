using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using LiteCart;
using System.Threading;

namespace LiteCart.LiteCart_Tests.CreateAccountTests
{
    class TestInputFields
    {
        [TestFixture]
        public class Test
        {
            private IWebDriver driver;
            private WebDriverWait wait;
            private CreateAccountPage createAccountPage;

            [SetUp]
            public void Start()
            {
                driver = new ChromeDriver();
                createAccountPage = new CreateAccountPage(driver);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            }
            [TestCase("Adam")]
            [TestCase("Петр")]
            [TestCase("12345")]
            [TestCase("#%$#^^%&")]
            [TestCase("😂😊👍")]
            [TestCase("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
            [TestCase(" ")]
            [TestCase("ADAM")]
            public void TestInputFirstName(string a)
            {
                createAccountPage.GoToUrl();
                createAccountPage.SetFirstName(a);
            }


            [TestCase("Adam")]
            [TestCase("Петр")]
            [TestCase("12345")]
            [TestCase("#%$#^^%&")]
            [TestCase("😂😊👍")]
            [TestCase("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890")]
            [TestCase(" ")]
            [TestCase("ADAM")]
            public void TestInputLastName(string a)
            {
                createAccountPage.GoToUrl();
                createAccountPage.SetLastName(a);
            }

            [TestCase("primer @mail.ru")]
            [TestCase("пример@mail.ru")]
            [TestCase("12345@mail.ru")]
            [TestCase("#%$#^^%&@mail.ru")]
            [TestCase("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop")]
            [TestCase("😂😊👍@mail.ru")]
            [TestCase("pri.mer@mail.ru")]
            [TestCase(".primer @mail.ru")]
            [TestCase("primer.@mail.ru")]
            [TestCase("pri..mer@mail.ru")]
            [TestCase("1")]
            public void TestInputEmail(string a)
            {
                createAccountPage.GoToUrl();
                createAccountPage.SetEmail(a);
                Thread.Sleep(6500);
            }

            [TestCase(" ")]
            [TestCase("Пароль1")]
            [TestCase("12345")]
            [TestCase("#%$#^^%&")]
            [TestCase("😂😊👍")]
            [TestCase("PAROL1")]
            [TestCase("ПАРОЛЬ1")]
            [TestCase("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop")]
            [TestCase("Parol1 ")]
           
            public void TestInputDesiredPassword(string a)
            {
                createAccountPage.GoToUrl();
                createAccountPage.SetDesiredPassword(a);
                Thread.Sleep(6500);
            }

            [TestCase(" ")]
            [TestCase("Пароль1")]
            [TestCase("12345")]
            [TestCase("#%$#^^%&")]
            [TestCase("😂😊👍")]
            [TestCase("PAROL1")]
            [TestCase("ПАРОЛЬ1")]
            [TestCase("qwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiop")]
            [TestCase("Parol1")]
            public void TestInputConfirmPassword(string a)
            {
                createAccountPage.GoToUrl();
                createAccountPage.SetConfirmPassword(a);
                
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