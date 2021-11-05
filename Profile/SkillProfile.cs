using System.Threading;
using MarsQA_1.Helpers;
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
        string VerifyAction = "//div[@class='ns-box-inner']";
        IWebElement UpdateBtn => Driver.driver.FindElement(By.XPath("(//input[@type = 'button'][@value = 'Update'])"));
        IWebElement AlertBoxMessage => Driver.driver.FindElement(By.XPath(VerifyAction));
        public void AddSkill()
        {
            SkillTab.Click();
            AddNewButton.Click();
            SkillTextField.SendKeys(Skill);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Level);
            AddButton.Click();
            Thread.Sleep(2000);
            SkillMessage = AlertBoxMessage.Text;
        }
        //Update
        public void UpdateSkill()
        {
            SkillTab.Click();
            var data = Skill;
            IWebElement EditButtonPen = Driver.driver.FindElement(By.XPath("//td[text()='" + data + "']/following::td[2]/descendant::i[@class='outline write icon']"));
            EditButtonPen.Click();
            SkillTextField.Clear();
            SkillTextField.SendKeys(Skill);
            var selectElement = new SelectElement(SelectLevel);
            selectElement.SelectByText(Level);
            UpdateBtn.Click();
            Thread.Sleep(2000);
            SkillMessage = AlertBoxMessage.Text;
        }
        // Delete an updated record
        public void DeleteSkill()
        {
            SkillTab.Click();
            var data1 = Skill;
            Thread.Sleep(2000);
            IWebElement ClearButtonPen = Driver.driver.FindElement(By.XPath("//td[text()='" + data1 + "']//following::td[2]//descendant::i[@class='remove icon']"));
            ClearButtonPen.Click();
            Thread.Sleep(2000);
            SkillMessage = AlertBoxMessage.Text;

        }
    }
}

