using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsQA_1.Pages
{
    class Education
    {
        private static IWebElement Education_ => Driver.driver.FindElement(By.XPath("//A[text()='Education']"));

        public static string title_name;
        private static IWebElement DeleteEduPen => Driver.driver.FindElement(By.XPath("(//td[text()='" + title_name + "']//following::i[@class='remove icon'])[1]"));
        private static IList<IWebElement> EduTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[3]/tbody/tr"));
        public static void Delete_Edu()
        {
            Helpers.Driver.TurnOnWait();

            Education_.Click();
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Anusree Rakesh\Desktop\Mars1\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Education");
            var data = ExcelLibHelper.ReadData(5, "Title");
            Driver.driver.FindElement(By.XPath("(//td[text()='" + data + "']//following::i[@class='remove icon'])[1]")).Click();
        }

        public static void VerifyEdu()
        {
            var data = ExcelLibHelper.ReadData(5, "Education");
            var row = EduTableRow.Count;
            for (var i = 1; i <= row; i++)
            {

                if (data == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]/tbody/tr[1]/td[1])[" + i + "]")).Text)
                {
                    Assert.AreNotEqual(data, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]/tbody/tr[1]/td[3])[" + i + "]")).Text);
                    break;

                }
            }
        }
    }
}
