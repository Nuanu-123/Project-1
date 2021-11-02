using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.Pages
{
    public static class Skills
    {
        private static IWebElement Skill => Driver.driver.FindElement(By.XPath("//A[text()='Skills']"));
        private static IWebElement AddSkill => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][text()='Add New']"));
        private static IWebElement UpdateSkill => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Add Skill']"));
        private static IWebElement ChooseSkillLevel => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui fluid dropdown'][@name='level']"));
        private static IList<IWebElement> SkillTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[2]/tbody/tr"));
        private static IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Update']"));
        public static string skill_name;
        private static IWebElement EditSkillpen => Driver.driver.FindElement(By.XPath("//td[text()='" + skill_name + "']/following::td[2]/descendant::i[@class='outline write icon']"));



        public static void Update_Skill()
        {
            Helpers.Driver.TurnOnWait();

            Skill.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Anusree Rakesh\Desktop\Mars1\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skill");
            var data = ExcelLibHelper.ReadData(2, "SkillName");
            Driver.driver.FindElement(By.XPath("//td[text()='" + data + "']/following::td[2]/descendant::i[@class='outline write icon']")).Click();

            SelectElement oSelect = new SelectElement(ChooseSkillLevel);
            oSelect.SelectByText(ExcelLibHelper.ReadData(2, "Level"));
            UpdateBtn.Click();

        }

        public static void VerifySkill()
        {
            string data = ExcelLibHelper.ReadData(2, "Skills");
            string skill_name_ = ExcelLibHelper.ReadData(2, "SkillName");
            string level_ = ExcelLibHelper.ReadData(2, "Level");
            if (skill_name_ == Driver.driver.FindElement(By.XPath(("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[1])"))).Text)
              {
                Assert.AreEqual(level_, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[2]/tbody/tr[1]/td[2])")).Text);
            
            }


        }
    }
}
