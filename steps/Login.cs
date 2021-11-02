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
    class Login
    {
     
    
        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {

            Pages.SignIn.Login();
        }

        

    }
}
