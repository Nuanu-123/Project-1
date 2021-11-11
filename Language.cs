using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.Feature
{
    [Binding]
    class Language

    {
        MarsQA_1.Pages.LanguageProfile LanguagePage = new Pages.LanguageProfile();

        [When(@"User entering ""(.*)"" and ""(.*)"" in Language tab and click Add button")]
        public void WhenUserEnteringAndInLanguageTabAndClickAddButton(string Language, string Level)
        {
           LanguagePage.AddLanguage(Language, Level);
        }

        [Then(@"""(.*)"" should be added in the list of languages")]
        public void ThenShouldBeAddedInTheListOfLanguages(string Language)
        {
            LanguagePage.VerifyAddLanguage(Language);
        }

        [When(@"User clicks on Edit button near ""(.*)""")]
        public void WhenUserClicksOnEditButtonNear(string Language)
        {
          LanguagePage.EditLanguage(Language);
        }

        [When(@"Update (.*) and (.*) and click update button")]
        public void WhenUpdateAndAndClickUpdateButton(string Language, string Level)
        {
           LanguagePage.UpdateLanguage(Language, Level);
        }
       
        [Then(@"(.*) should be updated")]
        public void ThenShouldBeUpdated(string Language)
        {
           LanguagePage.VerifyAddLanguage(Language);
        }

[When(@"When User selects to delete button near language ""(.*)""")]
        public void WhenWhenUserSelectsToDeleteButtonNearLanguage(string Language)
        {
         LanguagePage.DeleteLanguage(Language);
        }

        [Then(@"""(.*)"" should be deleted from the list of languages")]
        public void ThenShouldBeDeletedFromTheListOfLanguages(string Language)
        {
           LanguagePage.VerifyLanguageDeleted(Language);

        }
    }
}
