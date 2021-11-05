using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Education
    {

        MarsQA_1.SpecflowPages.Pages.EducationProfile EducationPage = new SpecflowPages.Pages.EducationProfile();

        [Given(@"User enter UniversityName as ""(.*)""")]
        public void GivenSellerEnterUniversityNameAs(string p0)
        {
            EducationPage.University = p0;
        }

        [Given(@"Select CountryOfUniversity as ""(.*)""")]
        public void GivenSelectCountryOfUniversityAs(string country)
        {
            EducationPage.Country = country;
        }
        [Given(@"Select Title as ""(.*)""")]
        public void GivenSelectTitleAs(string title)
        {
            EducationPage.Title = title;
        }
        [Given(@"Enter Degree as ""(.*)""")]
        public void GivenEnterDegreeAs(string degree)
        {
            EducationPage.Degree = degree;
        }
        [Given(@"Select YearOfGreaduation as ""(.*)""")]
        public void GivenSelectYearOfGraduationAs(int p0)
        {
            EducationPage.YearOfGraduation = p0;
        }
        [When(@"Clicks on Add button on AddEducation page")]
        public void WhenClicksOnAddButtonOnAddEducationPage()
        {
            EducationPage.AddEducation();
        }
        [Then(@"Education should be added to the  profile\. The Alert message ""(.*)"" is displayed\.")]
        public void ThenEducationShouldBeAddedToTheProfile_TheAlertMessageIsDisplayedOnTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, EducationPage.EducationMessage);
        }

        [When(@"User select to delete title ""(.*)""")]
        public void WhenSellerSelectToDeleteDegree(string title)
        {
            EducationPage.Title = title;
            EducationPage.DeleteEducation();
        }

       [Then(@"Education should be deleted\. The alert message, ""(.*)"" will be displayed\.")]
        public void ThenEducationShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, EducationPage.EducationMessage);
        }
    }
}
