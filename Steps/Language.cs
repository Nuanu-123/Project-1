using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Language

    {
        MarsQA_1.Pages.LanguageProfile LanguagePage = new Pages.LanguageProfile();

        [Given(@"User enter language as ""(.*)""")]
        public void GivenUserEnterLanguageAs(string Language)
        {
            LanguagePage.Languages = Language;

        }
        [Given(@"select level as ""(.*)""")]
        public void GivenSelectLevelAs(string Level)
        {
            LanguagePage.Levels = Level;
        }
        [When(@"clicks on Add action button")]
        public void WhenClicksOnAddActionButton()
        {
            LanguagePage.AddLanguage();
        }
        [Then(@"Language should be added to your profile\. The alert message, ""(.*)"" will be displayed\.")]
        public void ThenLanguageShouldBeAddedToYourProfile_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, LanguagePage.LanguageMessages);
        }

        [Given(@"User choose to update language ""(.*)""")]
        public void GivenUserChooseToUpdateLanguage(string Language)
        {
            LanguagePage.Languages = Language;
            LanguagePage.EditLanguage();

        }

        [Then(@"User updates language to ""(.*)""")]
        public void ThenUserUpdatesLanguageTo(string UpdatedLanguage)
        {
            LanguagePage.Languages = UpdatedLanguage;
        }

        [Then(@"updates level as ""(.*)""")]
        public void ThenUpdatesLevelAs(string UpdatedLevel)
        {

            LanguagePage.Levels = UpdatedLevel;
        }
        [When(@"clicks on Update button")]
        public void WhenClicksOnUpdateButton()
        {
            LanguagePage.UpdateLanguage();
        }

        [Then(@"Language should be updated\. The alert message, ""(.*)"" will be displayed\.")]
        public void ThenLanguageShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            //assert expected result = actual result
            Assert.AreEqual(message, LanguagePage.LanguageMessages);
        }

        [When(@"User select to delete language ""(.*)""")]
        public void WhenSellerSelectToDeleteLanguage(string UpdatedLanguage)
        {
            LanguagePage.Languages = UpdatedLanguage;
            LanguagePage.DeleteLanguage();
        }

        [Then(@"Language should be deleted\. The alert message, ""(.*)"" will be displayed\.")]
        public void ThenLanguageShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            //assert expected result = actual result
            Assert.AreEqual(message, LanguagePage.LanguageMessages);
        }

    }
}