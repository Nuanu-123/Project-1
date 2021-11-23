using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;
using static MarsQA_1.Helpers.CommonMethods;
using NUnit.Framework;
using System;

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
        IList<IWebElement> EduTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[1]/tbody/tr"));
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
        public void VerifyAddLanguage(string Language)
        {
            var ActualData = Language;
            var row = EduTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement AddedLanguage = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]"));
                string ExpectedData = AddedLanguage.GetAttribute("innerText");
                if (ActualData == ExpectedData)
                {
                    Assert.AreEqual(ExpectedData, ActualData);
                    return;
                }
            }
            Assert.Fail("No matching records");
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
        //Verify Langauge is deleted from profile
        public void VerifyLanguageDeleted(string Langauge)
        {
            LanguageTab.Click();
            Thread.Sleep(2000);

            if (Driver.driver.PageSource.Contains("" + Langauge + ""))
            {
                SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Language not Deleted");
                Assert.Fail("Language detail not deleted");
            }
            else
            {
                Assert.Pass("Language detail deleted");
                SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Language Deleted");
            }

        }
    }
}

