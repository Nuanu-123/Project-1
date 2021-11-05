using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Skills
    {
        MarsQA_1.Pages.SkillProfile SkillPage = new Pages.SkillProfile();
        [Given(@"User enter skill as ""(.*)""")]
        public void GivenUserEnterSkillAs(string Skill)
        {
            SkillPage.Skill = Skill;
        }

        [Given(@"select level as  ""(.*)""")]
        public void GivenSelectLevelAs(string Level)
        {
            SkillPage.Level = Level;
        }

        [When(@"clicks on Add  button")]
        public void WhenClicksOnAddButton()
        {
            SkillPage.AddSkill();
        }

        [Then(@"skill should be added to your profile\. The alert message, ""(.*)"" will be displayed\.")]
        public void ThenSkillShouldBeAddedToYourProfile_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, SkillPage.SkillMessage);
        }

        [Given(@"User updates skill as ""(.*)""")]
        public void GivenUserUpdatesSkillAs(string Skill)
        {
            SkillPage.Skill = Skill;
        }

        [Given(@"updates level as  ""(.*)""")]
        public void GivenUpdatesLevelAs(string Level)
        {
            SkillPage.Level = Level;
        }

        [When(@"clicks on Update  button")]
        public void WhenClicksOnUpdateButton()
        {
            SkillPage.UpdateSkill();
        }

        [Then(@"skill should be updated\. The alert message, ""(.*)"" will be displayed\.")]
        public void ThenSkillShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, SkillPage.SkillMessage);
        }
        
        [When(@"User select to delete language  ""(.*)""")]
        public void WhenUserSelectToDeleteLanguage(string Skill)
        {
            SkillPage.Skill = Skill;
            SkillPage.DeleteSkill();
        }

        [Then(@"skill should be deleted\. The alert message, ""(.*)"" will be displayed\.")]
        public void ThenSkillShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            Assert.AreEqual(message, SkillPage.SkillMessage);
        }

    }
}
