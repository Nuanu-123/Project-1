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
    public static class language
    {
        private static IWebElement Languages => Driver.driver.FindElement(By.XPath("(//A[text()='Languages'])[1]"));
        private static IWebElement AddLang => Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])"));
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Add Language']"));
        private static IWebElement ChooseLangLevel => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='level']"));
        private static IWebElement AddLangBtn => Driver.driver.FindElement(By.XPath("//input[@type='button'][@value='Add']"));
        private static IList<IWebElement> LangTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[1]/tbody/tr"));

        public static void Add_Language()
        {
            Helpers.Driver.TurnOnWait();
            AddLang.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Anusree Rakesh\Desktop\Mars1\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");
            AddLanguage.SendKeys(ExcelLibHelper.ReadData(2, "Language"));
            Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='level']"));
            SelectElement oSelect = new SelectElement(ChooseLangLevel);
            oSelect.SelectByText(ExcelLibHelper.ReadData(2, "Level"));
            AddLangBtn.Click();
            Helpers.Driver.TurnOnWait();
        }
        public static void VerifyLang()
        {
            var data = ExcelLibHelper.ReadData(2, "Language");
            var row = LangTableRow.Count;

            for (var i = 1; i <= row; i++)
            {

                if (data == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text)
                {
                    Assert.AreEqual(data, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text);
                    break;

                }


            }


        }
    }
}