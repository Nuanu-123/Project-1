using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages
{
    public class Sign_In
    {
         IWebElement SignInBtn => Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
         IWebElement Email => Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
         IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
         IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
       
        public void Login_()
        {
            Driver.NavigateUrl();
            SignInBtn.Click();
        }
        public void Login_Details(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
        }
        public void Click_Login()
        {
            LoginBtn.Click();
        }
    }
}