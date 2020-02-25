using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using TestPartnersPages.Models;
using TestPartnresPages.Models;
using NLog;
using TestPartners.Models;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using ExpectedConditions = OpenQA.Selenium.Support.UI.ExpectedConditions;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;

namespace WebPagesActions
{



    public class Page
    {

        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public IWebDriver driver { get; set; }
        ScreenShot screen;
        public Page(IWebDriver driver)
        {
            this.driver = driver;
            screen = new ScreenShot(driver);
        }

        public void Open(string url)
        {
            new ChromeDriver();

            driver.Navigate().GoToUrl(url);
            _logger.Debug($"Open url=>{url}");

        }

        public void LogintoMyPage(LoginSelectorsModel loginCssSelectors, string username, string password, string partername)
        {
            Console.WriteLine(partername);
            _logger.Debug("trying to login ");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            if (partername != "AdjaraBet")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(loginCssSelectors.LoginFormBtn)));
                driver.FindElement(By.CssSelector(loginCssSelectors.LoginFormBtn)).Click();

            }
            driver.FindElement(By.CssSelector(loginCssSelectors.UserNameInput)).SendKeys(username);
            driver.FindElement(By.CssSelector(loginCssSelectors.PasswordInput)).SendKeys(password);
            driver.FindElement(By.CssSelector(loginCssSelectors.LoginBtn)).Click();

            Thread.Sleep(1000);
        }



        public void GoToSport(string Selector, string Name, string URL)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("user-sign-in-component[class='user-sign-in-component component-specification ng-star-inserted']")));
                driver.FindElement(By.CssSelector(Selector)).Click();
            }
            catch
            {
                driver.Navigate().GoToUrl(URL);
            }


        }

        public void TakeScreenshot(string screenshotName)
        {
            Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
            file.SaveAsFile(string.Format(@"C:\TestResults\Quck Check results\Banners ScreenShots\{0}.png", screenshotName), ScreenshotImageFormat.Png);
        }

        public void PrematchBet(CheckBetModel selectors, string Name, GetNumberOfGamesCssSelectorsModel se)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000));
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(se.FrameName));
            Stopwatch s = new Stopwatch();
            s.Start();
            while (!CheckPresence.Check(driver, "span[class='inner']")&&s.Elapsed<TimeSpan.FromSeconds(10))
            {
                
                
            }
            s.Stop();
            wait3.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("div[class='loader-holder']")));
            

            try
            {
                driver.FindElements(By.ClassName("inner"))[0].Click();

                try
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[class='loading-content active']")));
                    wait2.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("div[class='loading-content active']")));
                    Console.WriteLine("BetCheck time");
                    _logger.Info("BetCheck time");
                }

                catch
                {
                    Console.WriteLine("NO BetCheck time");
                    _logger.Info("NO BetCheck time");
                }
                IWebElement SingleBetAmountInputElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selectors.SingleBetAmountInputElement)));
                SingleBetAmountInputElement.SendKeys(selectors.SingleBetAmount);
                try
                {
                    driver.FindElement(By.CssSelector("a[class='bet-btn accept-changes']")).Click();
                    Console.WriteLine("Odds changes were accepted");
                    _logger.Info("Odds changes were accepted");
                }

                catch
                {
                    Console.WriteLine("no Odds change ");
                    _logger.Info("no Odds change");
                }
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(selectors.BetBtn)));
                driver.FindElement(By.CssSelector(selectors.BetBtn)).Click();
                try { driver.FindElement(By.CssSelector("a[class='bet-btn accept-changes']")).Click(); driver.FindElement(By.CssSelector(selectors.BetBtn)).Click(); } catch { }
                wait1.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("i[class='icon efu-checkbox-checked-circle']")));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Single Bet-OK");
                Console.ResetColor();
                _logger.Info("Single Bet-OK");
            }
            catch (Exception ex)
            {
                screen.TakeScreenshot(Name);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message + "   Single Bet Fail");
                Console.ResetColor();
                _logger.Info(ex.Message + "Single Bet-Fail");
                try { driver.FindElement(By.CssSelector("i[class='efu-checkbox-error-circle']")).Click(); }
                catch{ }
            }
            try
            {
                wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(selectors.WaitAfterBetElement)));
            }
            catch
            {

                Console.WriteLine("Continue after single Failure ");
                _logger.Info("Continue after single Failure ");

            }
            try
            {
                driver.FindElements(By.XPath(selectors.GameBetElement))[3].Click();
                driver.FindElements(By.XPath(selectors.GameBetElement))[6].Click();



                try
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("div[class='loading-content active']")));
                    wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("div[class='loading-content active']")));
                    Console.WriteLine("Betcheck time ");
                    _logger.Info("Betcheck time ");
                }
                catch
                {
                    Console.WriteLine("No Betcheck time");
                    _logger.Info("NO Betcheck time ");
                }
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(selectors.MultipleBetAmountInputElement)));
                driver.FindElement(By.CssSelector(selectors.MultipleBetAmountInputElement)).SendKeys(selectors.MultipleBetAmount);
                try
                {
                    driver.FindElement(By.CssSelector("a[class='bet-btn accept-changes']")).Click();
                    Console.WriteLine("Odds changes were accepted");
                    _logger.Info("Odds changes were accepted");
                }

                catch
                {
                    Console.WriteLine("no Odds change ");
                    _logger.Info("no Odds change");
                }

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(selectors.BetBtn)));
                driver.FindElement(By.CssSelector(selectors.BetBtn)).Click();
                try { driver.FindElement(By.CssSelector("a[class='bet-btn accept-changes']")).Click(); driver.FindElement(By.CssSelector(selectors.BetBtn)).Click(); } catch { }
                try
                {
                    wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("i[class='icon efu-checkbox-checked-circle']")));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Multiple Bet-OK");
                    Console.ResetColor();
                    _logger.Info("Multiple Bet-OK");
                    wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("i[class='icon efu-checkbox-checked-circle']")));
                }
                catch (Exception ex)
                {
                    screen.TakeScreenshot(Name + "BetError");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message + "   Multiple Bet Fail1");
                    Console.ResetColor();
                    _logger.Info(ex.Message + "   Multiple Bet Fail1");
                    while (CheckPresence.Check(driver, "i[class='efu-checkbox-error-circle']"))
                    {
                        driver.FindElement(By.CssSelector("i[class='efu-checkbox-error-circle']")).Click();
                    }
                }


            }
            catch (Exception exs)
            {
                screen.TakeScreenshot(Name + "BetError");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exs.Message + "   Multiple Bet Fail");
                Console.ResetColor();
                _logger.Info(exs.Message + "   Multiple Bet Fail");
                while (CheckPresence.Check(driver, "i[class='efu-checkbox-error-circle']"))
                {
                    driver.FindElement(By.CssSelector("i[class='efu-checkbox-error-circle']")).Click();
                }

            }



        }
        public void LiveMatchBet(CheckBetModel checkBetModel, string partnerName)
        {

            driver.FindElements(By.XPath("//a[@href='/live']"))[0].Click();



            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(2));


            try
            {
                var va = wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.CssSelector("span[class='market']")));
                try { driver.FindElement(By.Id("live-stream-minity-btn")).Click(); } catch { };
                va[0].Click();
                try
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("div[class='loading-content active']")));
                    wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("div[class='loading-content active']")));
                    Console.WriteLine("BetCheck time");
                    _logger.Info("BetCheck time");
                }

                catch
                {
                    Console.WriteLine("NO BetCheck time");
                    _logger.Info("NO BetCheck time");
                }
                IWebElement SingleBetAmountInputElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(checkBetModel.SingleBetAmountInputElement)));
                SingleBetAmountInputElement.SendKeys(checkBetModel.SingleBetAmount);
                IWebElement elements;
                do
                {
                    try { driver.FindElement(By.CssSelector("a[class='bet-btn accept-changes']")).Click(); } catch { }
                    elements = driver.FindElement(By.CssSelector(checkBetModel.BetBtn));
                    elements.Click();
                    try
                    {
                        wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("i[class='icon efu-checkbox-checked-circle']")));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Live SingleBet-OK");
                        Console.ResetColor();
                    }
                    catch
                    {

                    }
                }
                while (CheckPresence.Check(driver, "a[class='bet-btn accept-changes']"));



            }
            catch (Exception ex)
            {

                screen.TakeScreenshot(partnerName);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message + "   Single Bet Fail");
                Console.ResetColor();
                _logger.Info(ex.Message + "Single Bet-Fail");
            }


        }




    }

}







