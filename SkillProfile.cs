using System.Collections.Generic;
using System.Threading;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.Pages
{
    public class SkillProfile
    {
        public string Skill { get; set; }
        public string Level { get; set; }
        public string SkillMessage { get; set; }
        IWebElement SkillTab => Driver.driver.FindElement(By.XPath("//A[text()='Skills']"));
        IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][text()='Add New']"));
        IWebElement SkillTextField => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Add Skill']"));
        IWebElement SelectLevel => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui fluid dropdown'][@name='level']"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Add'])"));
        IWebElement EditButtonPen => Driver.driver.FindElement(By.XPath("//td[text()='" + Skill + "']/following::td[2]/descendant::i[@class='outline write icon']"));
        IList<IWebElement> LangTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[2]/tbody/tr"));
        IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Update'])"));
        IWebElement ClearButtonPen => Driver.driver.FindElement(By.XPath("//td[text()='" + Skill + "']//following::td[2]//descendant::i[@class='remove icon']"));

        public void AddSkill()
        {
            SkillTab.Click();
            AddNewButton.Click();
            SkillTextField.SendKeys(Skill);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Level);
            AddButton.Click();
            Thread.Sleep(2000);
        }
        public void VerifyAddSkill()
        {
            var ActualData = Skill;
            var row = LangTableRow.Count;

            for (var i = 1; i <= row; i++)
            {
                if (ActualData == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])[" + i + "]")).Text)
                {
                    Assert.AreEqual(ActualData, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])[" + i + "]")).Text);
                    break;

                }
            }
        }
        //Update
        public void UpdateSkill()
        {
            SkillTab.Click();
            var data = Skill;
            EditButtonPen.Click();
            SkillTextField.Clear();
            SkillTextField.SendKeys(Skill);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Level);
            UpdateBtn.Click();
            Thread.Sleep(2000);

        }
        // Delete an updated record
        public void DeleteSkill()
        {
            SkillTab.Click();
            //  var data1 = Skill;
            Thread.Sleep(2000);
            ClearButtonPen.Click();
            Thread.Sleep(2000);
        }
        public void VerifyDeleteSkill()
        {
            var ActualData = Skill;
            var row = LangTableRow.Count;

            for (var i = 1; i <= row; i++)
            {
                if (ActualData == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])[" + i + "]")).Text)
                {
                    Assert.AreNotEqual(ActualData, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])[" + i + "]")).Text);
                    break;

                }
            }
        }

    }
}

