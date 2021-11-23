using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;
using System;
using System.Reflection;

namespace MarsQA_1.Pages
{

    public class EducationProfile
    {
        IWebElement EducationTab => Driver.driver.FindElement(By.XPath("(//A[text()='Education'])[1]"));
        IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])[3]"));
        IWebElement UniversityName => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='College/University Name']"));
        IWebElement CountryName => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='country']"));
        IWebElement TitleDropDown => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='title']"));
        IWebElement DegreeName => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Degree']"));
        IWebElement GraduationYear => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='yearOfGraduation']"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("(//input[@type='button'][@value='Add'])"));
        IList<IWebElement> LangTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[3]/tbody/tr"));
        public void AddEducation(string University, string Country, string Title, string Degree, int YearOfGraduation)
        {
            EducationTab.Click();
            AddNewButton.Click();
            UniversityName.SendKeys(University);
            //select country name 
            var SelectCountry = new SelectElement(CountryName);
            SelectCountry.SelectByText(Country);
            //select title 
            var SelectTitle = new SelectElement(TitleDropDown);
            SelectTitle.SelectByText(Title);
            DegreeName.SendKeys(Degree);
            //select graduation year 
            var SelectGradYear = new SelectElement(GraduationYear);
            SelectGradYear.SelectByText(YearOfGraduation.ToString());
            AddButton.Click();
            Thread.Sleep(2000);
        }
        public void VerifyEducationAdded(string Title)
        {
            var ActualData = Title;
            var row = LangTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement AddedEducation = Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]/tbody/tr[1]/td[3])[" + i + "]"));
                string ExpectedData = AddedEducation.GetAttribute("innerText");
                if (ActualData == ExpectedData)
                {

                    Assert.AreEqual(ExpectedData, ActualData);
                    return;
                }
            }
            Assert.Fail("No matching records");
        }
        // Delete added record
        public void DeleteEducation(string Title)
        {
            EducationTab.Click();
            IWebElement EduDeleteButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Title + "']//following::td[3]//descendant::i[@class='remove icon']"));
            EduDeleteButton.Click();
            Thread.Sleep(4000);
        }
        public void VerifyEducationDeleted(string Title)
        {
            EducationTab.Click();
            Thread.Sleep(2000);
            if (Driver.driver.PageSource.Contains("" + Title + ""))
            {
              //  SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Education Detail Not Deleted");
                Assert.Fail("Education detail not deleted"); 
            }
            else
            {
                Assert.Pass("Record Deleted from list");
               // SaveScreenShotClass.SaveScreenshot((IWebDriver)Driver.driver, "Education Detail Deleted");
            }
        }

    }
}

