using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Pages
{
    public class LanguageProfile
    {
        IWebElement LanguageTab => Driver.driver.FindElement(By.XPath("(//A[text()='Languages'])"));
        IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])[1]"));
        IWebElement LanguageName => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Add Language']"));
        IWebElement SelectLevel => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='level']"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Add']"));
        IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Update'])"));
        public void AddLanguage(string Languages, string Levels)
        {
            LanguageTab.Click();
            AddNewButton.Click();
            LanguageName.SendKeys(Languages);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Levels);
            AddButton.Click();
            Thread.Sleep(2000);
        }
        //Verify Language is added successfully
        public void VerifyAddLanguage(string Language)
        {
            bool LanguagePresent = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("(//table[@class='ui fixed table'])[1]"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            foreach (IWebElement row in tableRow)
            {
                if (row.Text.Contains(Language))
                {
                    LanguagePresent = true;
                    SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Language Added");
                    break;
                }
            }
        }
        //Verify Langauge is deleted from profile
        public void VerifyLanguageDeleted(string Langauge)
        {
            LanguageTab.Click();
            Thread.Sleep(2000);

            if (Driver.driver.PageSource.Contains("" + Langauge + ""))
            {
                SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Language not Deleted");
            }
            else
            {
                SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Language Deleted");
            }

        }

        public void EditLanguage(string Languages)
        {
            LanguageTab.Click();
            IWebElement EditPen = Driver.driver.FindElement(By.XPath("//td[text()='" + Languages + "']/following::td[2]/descendant::i[@class='outline write icon']"));
            EditPen.Click();
        }
        public void UpdateLanguage(string UpdatedLanguages, string UpdatedLevels)
        {
            LanguageName.Clear();
            LanguageName.SendKeys(UpdatedLanguages);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(UpdatedLevels);
            UpdateBtn.Click();
            Thread.Sleep(2000);
        }
        // Delete record
        public void DeleteLanguage(string UpdatedLanguages)
        {
            LanguageTab.Click();
            IWebElement RemovePen = Driver.driver.FindElement(By.XPath("//td[text()='" + UpdatedLanguages + "']/following::td[2]/descendant::i[@class='remove icon']"));
            RemovePen.Click();
            Thread.Sleep(8000);

        }
    }
}

