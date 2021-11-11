using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.Feature
{
    [Binding]
    class Skills
    {
        MarsQA_1.Pages.SkillProfile SkillPage = new Pages.SkillProfile();

        [When(@"User enter ""(.*)"" and ""(.*)"" in Skill tab and click Add button")]
        public void WhenUserEnterAndInSkillTabAndClickAddButton(string Skill, string Level)
        {
            SkillPage.AddSkill(Skill, Level);
        }

        [Then(@"""(.*)"" should be added in the list of Skills")]
        public void ThenShouldBeAddedInTheListOfSkills(string Skill)
        {
            SkillPage.VerifySkillAdded(Skill);
        }
        [When(@"User clicks on Edit near ""(.*)""")]
        public void WhenUserClicksOnEditNear(string Skill)
        {
            SkillPage.EditSkillbutton(Skill);
        }

        [When(@"Update ""(.*)"" and ""(.*)"" and click update")]
        public void WhenUpdateAndAndClickUpdate(string Skill, string Level)
        {
           SkillPage.UpdateSkill(Skill, Level);
        }

        [Then(@"""(.*)"" should be updated for the ""(.*)""")]
        public void ThenShouldBeUpdatedForThe(string Skill, string Level)
        {
            SkillPage.VerifyEditSkill(Skill, Level);
        }

        [When(@"User clicks on remove btn near ""(.*)""")]
        public void WhenUserClicksOnRemoveBtnNear(string Skill)
        {
            SkillPage.DeleteSkill(Skill);
        }

        [Then(@"""(.*)"" should be deleted from the list")]
        public void ThenShouldBeDeletedFromTheList(string Skill)
        {
           SkillPage.VerifySkillDeleted(Skill);
        }
 }
}

