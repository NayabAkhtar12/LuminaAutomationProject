using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        //Objects
        TextToImage TxttoImage;
        RemixImage RemxImage;



        [TestMethod]
        public void TextToImageMethod()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            TxttoImage = new TextToImage(driver, test);
            TxttoImage.TexttoImsage();
        }

        //[TestMethod]
        //public void RemixImageMethod()
        //{
        //    ExtentTest test = Extent.CreateTest("Famous Places Report");
        //    RemxImage = new RemixImage(driver, test);
        //    RemxImage.RemixImageMethod();

        //}
    }
}
