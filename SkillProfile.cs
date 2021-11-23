using System;
using System.Collections.Generic;
using System.Threading;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Pages
{
    public class SkillProfile
    {
        IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//A[text()='Skills']"));
        IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][text()='Add New']"));
        IWebElement SkillTextField => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Add Skill']"));
        IWebElement SelectLevel => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui fluid dropdown'][@name='level']"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Add'])"));
        IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Update'])"));
        IList<IWebElement> SkillTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[2]/tbody/tr"));

        public void AddSkill(string Skill, string Level)
        {
            SkillTab.Click();
            AddNewButton.Click();
            SkillTextField.SendKeys(Skill);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Level);
            AddButton.Click();
            Thread.Sleep(2000);
        }

        public void VerifySkillAdded(string Skill)
        {
            var ActualData = Skill;
            var row = SkillTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement AddedLanguage = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])[" + i + "]"));
                string ExpectedData = AddedLanguage.GetAttribute("innerText");
                if (ActualData == ExpectedData)
                {
                    Assert.AreEqual(ExpectedData, ActualData);
                    return;
                }
            }
            Assert.Fail("No matching records");
        }

        public void EditSkillbutton(string Skill)
        {
            SkillTab.Click();
            var data = Skill;
            IWebElement EditButtonPen = Driver.driver.FindElement(By.XPath("//td[text()='" + Skill + "']/following::td[2]/descendant::i[@class='outline write icon']"));
            EditButtonPen.Click();
        }
       
      
        public void UpdateSkill(string UpdatedSkill, string UpdatedLevel)
        {
            SkillTextField.Clear();
            SkillTextField.SendKeys(UpdatedSkill);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(UpdatedLevel);
            UpdateBtn.Click();
            Thread.Sleep(2000);
        }
        public void VerifyEditSkill(string Skill, string Level)

        {
            SkillTab.Click();
            var rownum = SkillTableRow.Count;
            for (var i = 1; i <= rownum; i++)
            {
                string SkillName = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])[" + i + "]")).Text;
                string LevelName = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[2])[" + i + "]")).Text;
                if ((Skill == SkillName) && (Level == LevelName))
                {
                    Assert.AreEqual(Level, LevelName);
                    return;
                }
            }
            Assert.Fail("Not updated");
        }
        // Delete an updated record
        public void DeleteSkill(string UpdatedSkill)
        {
            SkillTab.Click();
            IWebElement ClearButtonPen = Driver.driver.FindElement(By.XPath("//td[text()='" + UpdatedSkill + "']//following::td[2]//descendant::i[@class='remove icon']"));
            ClearButtonPen.Click();
            Thread.Sleep(6000);
        }
       public void VerifySkillDeleted(string UpdatedSkill)
        {
            SkillTab.Click();
            Thread.Sleep(2000);

            if (Driver.driver.PageSource.Contains("" + UpdatedSkill + ""))
            {
                SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Skill Not Deleted");
                Assert.Fail("Skill detail not deleted");
            }
            else
            {
                Assert.Pass("Skill detail deleted");
                SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Skill Deleted");
            }

        }

    }
}