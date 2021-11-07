using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class EducationProfile
    {
        public string Country { get; set; }
        public string University { get; set; }
        public string Title { get; set; }
        public string Degree { get; set; }
        public int YearOfGraduation { get; set; }
        public string EducationMessage { get; set; }

        IWebElement EducationTab => Driver.driver.FindElement(By.XPath("(//A[text()='Education'])[1]"));
        IWebElement AddNewButton => Driver.driver.FindElement(By.XPath("(//div[text()='Add New'])[3]"));
        IWebElement UniversityName => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='College/University Name']"));
        IWebElement CountryName => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='country']"));
        IWebElement TitleDropDown => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='title']"));
        IWebElement DegreeName => Driver.driver.FindElement(By.XPath("//INPUT[@placeholder='Degree']"));
        IWebElement GraduationYear => Driver.driver.FindElement(By.XPath("//SELECT[@class='ui dropdown'][@name='yearOfGraduation']"));
        IWebElement AddButton => Driver.driver.FindElement(By.XPath("(//input[@type='button'][@value='Add'])"));
        IWebElement EduDeleteButton => Driver.driver.FindElement(By.XPath("//td[text()='" + Title + "']//following::td[3]//descendant::i[@class='remove icon']"));
        IList<IWebElement> LangTableRow => Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[3]/tbody/tr"));

        public void AddEducation()
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
        public void VerifyAddEducation()
        {
            var ActualData = Title;
            var row = LangTableRow.Count;

            for (var i = 1; i <= row; i++)
            {
                if (ActualData == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]/tbody/tr[1]/td[3])[" + i + "]")).Text)
                {
                    Assert.AreEqual(ActualData, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]/tbody/tr[1]/td[3])[" + i + "]")).Text);
                    break;

                }
            }
        }

        // Delete added record
        public void DeleteEducation()

        {
            EducationTab.Click();
            var data = Title;
            Thread.Sleep(2000);
            EduDeleteButton.Click();
            Thread.Sleep(2000);
        }
        public void VerifyDeleteEducation()
        {
            var ActualData = Title;
            var row = LangTableRow.Count;

            for (var i = 1; i <= row; i++)
            {
                if (ActualData == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]/tbody/tr[1]/td[3])[" + i + "]")).Text)
                {
                    Assert.AreNotEqual(ActualData, Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[3]/tbody/tr[1]/td[3])[" + i + "]")).Text);
                    break;

                }
            }
        }
    }
}

