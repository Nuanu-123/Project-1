using MarsQA_1.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Education
    {
        MarsQA_1.SpecflowPages.Pages.EducationProfile EducationPage = new SpecflowPages.Pages.EducationProfile();
        [When(@"User enter UniversityName as ""(.*)"",CountryOfUniversity as ""(.*)"",Title as ""(.*)"", Degree as ""(.*)"" and  YearOfGreaduation as ""(.*)""")]
        public void WhenUserEnterUniversityNameAsCountryOfUniversityAsTitleAsDegreeAsAndYearOfGreaduationAs(string university, string country, string title, string degree, int p0)
        {
            EducationPage.University = university;
            EducationPage.Country = country;
            EducationPage.Title = title;
            EducationPage.Degree = degree;
            EducationPage.YearOfGraduation = p0;
        }

        [When(@"Clicks on Add button on Education page")]
        public void WhenClicksOnAddButtonOnEducationPage()
        {
            EducationPage.AddEducation();
        }

        [Then(@"New Education details should be added to the  profile\.")]
        public void ThenNewEducationDetailsShouldBeAddedToTheProfile_()
        {
            EducationPage.VerifyAddEducation();
        }

        [Given(@"""(.*)"" is added to education")]
        public void GivenIsAddedToEducation(string title)
        {
            EducationPage.Title = title;
        }

        [When(@"User selects to delete ""(.*)""")]
        public void WhenUserSelectsToDelete(string title)
        {
            EducationPage.Title = title;
            EducationPage.DeleteEducation();
        }

        [Then(@"Education detail should be deleted from the list\.")]
        public void ThenEducationDetailShouldBeDeletedFromTheList_()
        {
            EducationPage.VerifyDeleteEducation();
        }

    }
}

