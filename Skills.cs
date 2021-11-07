using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Skills
    {
        MarsQA_1.Pages.SkillProfile SkillPage = new Pages.SkillProfile();
        [When(@"User enter skill as ""(.*)"" and level as ""(.*)""")]
        public void WhenUserEnterSkillAsAndLevelAs(string Skill, string Level)
        {
            SkillPage.Skill = Skill;
            SkillPage.Level = Level;
        }

        [When(@"clicks on Add button in education tab")]
        public void WhenClicksOnAddButtonInEducationTab()
        {
            SkillPage.AddSkill();
        }

        [Then(@"skill should be added to your profile\.")]
        public void ThenSkillShouldBeAddedToYourProfile_()
        {
          SkillPage.VerifyAddSkill();
        }

        [Given(@"Skill ""(.*)"" is added")]
        public void GivenSkillIsAdded(string Skill)
        {
            SkillPage.Skill = Skill;
        }

        [When(@"User updates Skill to ""(.*)"" and level as ""(.*)""")]
        public void WhenUserUpdatesSkillToAndLevelAs(string UpdatedSkill, string UpdatedLevel)
        {
            SkillPage.Skill = UpdatedSkill;
            SkillPage.Level = UpdatedLevel;
        }

        [When(@"clicks on update button in education tab")]
        public void WhenClicksOnUpdateButtonInEducationTab()
        {
          SkillPage.UpdateSkill();
        }

        [Then(@"""(.*)"" added in the list of skills")]
        public void ThenAddedInTheListOfSkills(string UpdatedSkill)
        {
            SkillPage.Skill = UpdatedSkill;
            SkillPage.VerifyAddSkill();
        }

        [When(@"User select to delete skill ""(.*)""")]
        public void WhenUserSelectToDeleteSkill(string UpdatedSkill)
        {
            SkillPage.Skill = UpdatedSkill;
            SkillPage.DeleteSkill();
        }

        [Then(@"skill should be deleted from the list\.")]
        public void ThenSkillShouldBeDeletedFromTheList_()
        {
            SkillPage.VerifyDeleteSkill();
        }

    }
}