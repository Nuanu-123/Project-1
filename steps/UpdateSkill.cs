using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateSkillSteps
    {
       
        [Given(@"I click update and update skill and level")]
        public void GivenIClickUpdateAndUpdateSkillAndLevel()
        {
            Pages.Skills.Update_Skill();
            
        }
        [Then(@"I verify skill is successfully deleted")]
        public void ThenIVerifySkillIsSuccessfullyDeleted()
        {
            Pages.Skills.VerifySkill();
        }


    }
}
