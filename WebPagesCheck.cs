using System;
using WebPagesActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestPartnersPages;
using NLog;
using System.Threading;
using System.IO;
using System.Reflection;

namespace QuickCheck

{



    public class WebPagesCheck
    {





        public static void Main()
        {
            Helpers.InitializePartnersDataList();

            while (true)
            {
                var driver = GetChromeDriver();
                driver.Manage().Window.Maximize();
                foreach (var partnerData in Helpers.PartnerDatas)
                {
                    try
                    {
                        var page = new Page(driver);
                        page.Open(partnerData.Url);
                        page.LogintoMyPage(partnerData.LoginCssSelectors, partnerData.UserName, partnerData.Password, partnerData.PartnerName);
                        page.TakeScreenshot(string.Format("{0}Login", partnerData.PartnerName));
                        page.GoToSport(partnerData.SportButtonSelector, partnerData.PartnerName, partnerData.HelpUrl);
                        page.PrematchBet(partnerData.CheckBetModel, partnerData.PartnerName, partnerData.GetNumberOfGamesCssSelectorsModel);
                        page.LiveMatchBet(partnerData.CheckBetModel, partnerData.PartnerName);
                        Console.WriteLine("--------------------------------------");

                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                        Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
                        file.SaveAsFile(string.Format(@"C:\TestResults\Quck Check results\ErrorScreenShots\Error.png"), ScreenshotImageFormat.Png);
                    }

                }
                driver.Quit();
                //Thread.Sleep(TimeSpan.FromHours(3));
            }

        }

        private static ChromeDriver GetChromeDriver()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(path);
        }
    }
}








