using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiteCart
{
     public class CreateAccountPage
     {
        private IWebDriver driver;
        private WebDriverWait wait;

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void GoToUrl()
        {
            driver.Url = "http://localhost/litecart/create_account";
        }

        public void SetFirstName(string firstname)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(firstname);
        }

        public void SetLastName(string lastname)
        {
            driver.FindElement(By.Name("lastname")).SendKeys(lastname);
        }

        public void SetEmail(string email)
        {
            driver.FindElement(By.Name("Email")).SendKeys(email);
        }
        public void SetDesiredPassword(string desiredpassword)
        {
            driver.FindElement(By.Name("password")).SendKeys(desiredpassword);
        }
        public void SetConfirmPassword(string confirmdpassword)
        {
            driver.FindElement(By.Name("confirmed_password")).SendKeys(confirmdpassword);
        }

        

     }
}
