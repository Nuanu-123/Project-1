using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

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
        IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Update'])"));
        IWebElement EditPen => Driver.driver.FindElement(By.XPath("//td[text()='" + Languages + "']/following::td[2]/descendant::i[@class='outline write icon']"));
        IWebElement RemovePen => Driver.driver.FindElement(By.XPath("//td[text()='" + Languages + "']/following::td[2]/descendant::i[@class='remove icon']"));
        IList<IWebElement> LangTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[1]/tbody/tr"));
        public void AddLanguage()
        {
            LanguageTab.Click();
            AddNewButton.Click();
            LanguageName.SendKeys(Languages);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Levels);
            AddButton.Click();
            Thread.Sleep(2000);
        }
        public void VerifyAddLang()
        {
            var ActualData = Languages;
            var row = LangTableRow.Count;

            for (var i = 1; i <= row; i++)
            {
                if (ActualData == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text)
                {
                    Assert.AreEqual(ActualData, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text);
                    break;

                } 
            }
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
            UpdateBtn.Click();
            Thread.Sleep(2000);

        }
        // Delete record
        public void DeleteLanguage()
        {
            LanguageTab.Click();
            RemovePen.Click();
            Thread.Sleep(2000);
        }
        public void VerifyDeleteLang()
        {
            var ActualData = Languages; 
            var row = LangTableRow.Count;

            for (var i = 1; i <= row; i++)
            {
                if (ActualData == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text)
                {
                    Assert.AreNotEqual(ActualData, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text);
                    break;

                }

            }
        }

    }
}