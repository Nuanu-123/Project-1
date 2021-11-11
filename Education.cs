using MarsQA_1.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Education
    {
        MarsQA_1.SpecflowPages.Pages.EducationProfile EducationPage = new SpecflowPages.Pages.EducationProfile();

        [When(@"User adds new education details  ""(.*)"",""(.*)"", ""(.*)"",""(.*)"",""(.*)""")]

        public void WhenUserAddsNewEducationDetails(string University, string Country, string Title, string Degree, int YearOfGraduation)
        {
            EducationPage.AddEducation(University, Country, Title, Degree, YearOfGraduation);
        }

        [Then(@"The  education detail with ""(.*)"" should be added to the Education page")]
        public void ThenTheEducationDetailWithShouldBeAddedToTheEducationPage(string Title)
        {
            EducationPage.VerifyEducationAdded(Title);
        }

        [When(@"When User selects to delete education with ""(.*)""")]
        public void WhenWhenUserSelectsToDeleteEducationWith(string Title)
        {
            EducationPage.DeleteEducation(Title);
        }

        [Then(@"""(.*)"" should be deleted from the list of education details")]
        public void ThenShouldBeDeletedFromTheListOfEducationDetails(string Title)
        {
            EducationPage.VerifyEducationDeleted(Title);
        }
    }
}