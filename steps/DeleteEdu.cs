using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class DeleteEdu
    {

        [Given(@"I delete the details of given education")]
        public void GivenIDeleteTheDetailsOfGivenEducation()
        {
            Pages.Education.Delete_Edu();
        }

        [Then(@"I verify education is successfully deleted")]
        public void ThenIVerifyEducationIsSuccessfullyDeleted()
        {
            Pages.Education.VerifyEdu();
        }


    }
}
