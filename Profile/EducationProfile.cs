using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        string VerifyAction = "//div[@class='ns-box-inner']";
        IWebElement AlertBoxMessage => Driver.driver.FindElement(By.XPath(VerifyAction));

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
            EducationMessage = AlertBoxMessage.Text;
        }

        // Delete added record
        public void DeleteEducation()

        {
            EducationTab.Click();
            var data = Title;
            Thread.Sleep(2000);
            IWebElement EduDeleteButton = Driver.driver.FindElement(By.XPath("//td[text()='" + data + "']//following::td[3]//descendant::i[@class='remove icon']"));
            EduDeleteButton.Click();
            Thread.Sleep(2000);
            EducationMessage = AlertBoxMessage.Text;
        }
    }
}

