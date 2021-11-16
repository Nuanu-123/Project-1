using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class LanguageProfile
    {
        public string Languages { get; set; }
        public string Levels { get; set; }
        public string LanguageMessages { get; set; }
        IWebElement LanguageTab => Driver.driver.FindElement(By.XPath("(//A[text()='Languages'])"));
        IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])[1]"));
        IWebElement LanguageName => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Add Language']"));
        IWebElement SelectLevel => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='level']"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Add']"));
        IWebElement EditPen => Driver.driver.FindElement(By.XPath("//td[text()='" + Languages + "']/following::td[2]/descendant::i[@class='outline write icon']"));
        string VerifyAction = "//div[@class='ns-box-inner']";
        IWebElement AlertBoxMessage => Driver.driver.FindElement(By.XPath(VerifyAction));

        public void AddLanguage()
        {
            LanguageTab.Click();
            AddNewButton.Click();
            LanguageName.SendKeys(Languages);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Levels);
            AddButton.Click();
            Thread.Sleep(2000);
            LanguageMessages = AlertBoxMessage.Text;
        }
        public void EditLanguage()
        {
            LanguageTab.Click();
            EditPen.Click();
        }
        public void UpdateLanguage()
        {
            LanguageName.Clear();
            LanguageName.SendKeys(Languages);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Levels);
            IWebElement UpdateBtn = Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Update'])"));
            UpdateBtn.Click();
            Thread.Sleep(2000);
            LanguageMessages = AlertBoxMessage.Text;

        }
        // Delete record
        public void DeleteLanguage()
        {
            LanguageTab.Click();
            var data1 = Languages;
            IWebElement RemovePen = Driver.driver.FindElement(By.XPath("//td[text()='" + data1 + "']/following::td[2]/descendant::i[@class='remove icon']"));
            RemovePen.Click();
            Thread.Sleep(2000);
            LanguageMessages = AlertBoxMessage.Text;

        }
    }
}

