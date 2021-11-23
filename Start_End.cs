
using MarsQA_1.Helpers;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Utils
{
    [Binding]
    public sealed class Hooks3 : Driver
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //launch the browser
            Initialize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
           // Close the browser
            Close();
        }
    }
}
//[Binding]
//public class Start : Driver
//{
//    [BeforeScenario]
//    public void Setup()
//    {
//        //launch the browser
//        Initialize();
//        ExcelLibHelper.PopulateInCollection(@"C:\Users\Anusree Rakesh\Desktop\Mars1\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
//        //call the SignIn class
//        SignIn.SigninStep();
//    }
//    [AfterScenario]
//    public void TearDown()
//    {
//        ExtentReports();
//        // Screenshot
//        string img = SaveScreenShotClass.SaveScreenshot(driver, "Report");
//        test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
//        //Close the browser
//        Close();
//        // end test. (Reports)
//        Extent.EndTest(test);
//        // calling Flush writes everything to the log file (Reports)
//        //Extent.Flush();
//        // Extent.Flush();

//    }


//}
//}