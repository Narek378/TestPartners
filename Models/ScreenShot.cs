using NLog;
using OpenQA.Selenium;

namespace TestPartnresPages.Models
{
    class ScreenShot
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public ScreenShot(IWebDriver driver)
        {
            this.driver = driver;
        }


        public  IWebDriver driver { get; set; }
        public  void TakeScreenshot(string name)
        {
            Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
            file.SaveAsFile(string.Format(@"C:\TestResults\Quck Check results\ErrorScreenShots\{0}.png", name), ScreenshotImageFormat.Png);
        }
    }
}