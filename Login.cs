using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using MarsQA_1.Pages;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login
    {
        Sign_In sign_in = new Sign_In();

        [Given(@"I navigate to application and click SignIn")]
        public void GivenINavigateToApplicationAndClickSignIn()
        {
            sign_in.Login_();
        }

        [Given(@"I enter the login credentials and click login")]
        public void GivenIEnterTheLoginCredentialsAndClickLogin(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            sign_in.Login_Details((string)data.Email, (string)data.Password);
            sign_in.Click_Login();
        }
    }
}
