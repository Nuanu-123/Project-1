using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MarsQA_1.Feature
{
    [Binding]
    class AddLang
    {

        [Given(@"I add language and level")]
        public void GivenIAddLanguageAndLevel()
        {
            Pages.language.Add_Language();
        }


        [Then(@"I verify Language is successfully added")]
        public void ThenIVerifyLanguageIsSuccessfullyAdded()
        {
            Pages.language.VerifyLang();
        }


    }
}
