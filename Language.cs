using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Language

    {
        MarsQA_1.Pages.LanguageProfile LanguagePage = new Pages.LanguageProfile();
        [When(@"User enter language as ""(.*)"" and  level as ""(.*)""")]
        public void WhenUserEnterLanguageAsAndLevelAs(string language, string level)
        {
            LanguagePage.Languages = language;
            LanguagePage.Levels = level;
        }
        [When(@"clicks on Add button")]
        public void WhenClicksOnAddButton()
        {
            LanguagePage.AddLanguage();
        }
        [Then(@"""(.*)"" should be added in the list of languages")]
        public void ThenShouldBeAddedInTheListOfLanguages(string language)
        {
            LanguagePage.Languages = language;
            LanguagePage.VerifyAddLang();
        }
        [Given(@"Language ""(.*)"" is added")]
        public void GivenLanguageIsAdded(string Language)
        {
            LanguagePage.Languages = Language;
            LanguagePage.EditLanguage();
        }

        [When(@"User updates language to ""(.*)"" and level as ""(.*)""")]
        public void WhenUserUpdatesLanguageToAndLevelAs(string UpdatedLanguage, string UpdatedLevel)
        {
            LanguagePage.Languages = UpdatedLanguage;
            LanguagePage.Levels = UpdatedLevel;
        }
        [When(@"clicks on update button")]
        public void WhenClicksOnUpdateButton()
        {
            LanguagePage.UpdateLanguage();
        }

        [Then(@"I should see ""(.*)"" added in the list of languages")]
        public void ThenIShouldSeeAddedInTheListOfLanguages(string language)
        {
            LanguagePage.Languages = language;
            LanguagePage.VerifyAddLang();
        }

        [When(@"User select to delete language ""(.*)""")]
        public void WhenSellerSelectToDeleteLanguage(string UpdatedLanguage)
        {
            LanguagePage.Languages = UpdatedLanguage;
            LanguagePage.DeleteLanguage();

        }

        [Then(@"""(.*)"" should be deleted from the list of languages")]
        public void ThenShouldBeDeletedFromTheListOfLanguages(string UpdatedLanguage)
        {
            LanguagePage.Languages = UpdatedLanguage;
            LanguagePage.VerifyDeleteLang();
        }

    }
}