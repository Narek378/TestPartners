using NLog;
using System.Collections.Generic;
using TestPartnersPages.Models;

namespace TestPartnersPages
{
    public static class Helpers
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static List<PartnerData> PartnerDatas { get; set; }

        public static void InitializePartnersDataList()
        {
            PartnerDatas = new List<PartnerData>();
            PartnerDatas.Add(new PartnerData
            {
                PartnerName = "TehranBet",
                Url = "https://t3t.website/home",
                HelpUrl = "https://t3t.website/sport/prematch",
                UserName = "Narek378",
                Password = "Nar015781993",
                SportButtonSelector = "a[href='/sport/prematch'][ng-reflect-klass='link']",
                LoginCssSelectors = new LoginSelectorsModel
                {
                    LoginFormBtn = "a[class='button-component size-4 ext-1']",
                    UserNameInput = "input[formcontrolname = 'login']",
                    PasswordInput = "input[formcontrolname='pass']",
                    LoginBtn = "button[class='button-component size-2 full ext-2']"
                },
                GetNumberOfGamesCssSelectorsModel = new GetNumberOfGamesCssSelectorsModel
                {
                    FrameName = "sportsbookIframe",
                    PreMatchSelector = "//a[@class='tree-button-component active']//span[@class='count']",
                    LiveMatchSelector = "//a[@class='tree-button-component']//span[@class='count']",
                    WebSiteName = "TehranBet"
                },
                CheckBetModel = new CheckBetModel
                {
                    //BetFrameName = "sportsbookIframe",
                    GameBetElement = "//prematch-component[@class='prematch-component competition-component']//span[@class='inner']",
                    SingleBetAmountInputElement = "input[name='bet']",
                    SingleBetAmount = "5000",
                    BetBtn = "a[class='bet-btn bet-now']",
                    MultipleBetAmountInputElement = "input[placeholder='min 5000']",
                    MultipleBetAmount = "5000",
                    WaitAfterBetElement = "//*[text()='your betslip is empty']"
                }
            });
            PartnerDatas.Add(new PartnerData
            {
                PartnerName = "AdjaraBet",
                Url = "https://www.adjarabet.am/en",
                HelpUrl = "https://sports.adjarabet.am/en/Sportsbook",
                UserName = "estlgam27",
                Password = "uJMd7U1hAO",
                SportButtonSelector = "a[class='_css_text--cursor'][href='https://sports.adjarabet.am/hy/Sportsbook']",
                LoginCssSelectors = new LoginSelectorsModel
                {
                    LoginFormBtn = "button[class='_css_button--red _css_nowrap ']",
                    UserNameInput = "input[data-id='username']",
                    PasswordInput = "input[data-id='password']",
                    LoginBtn = "button[class='_cs_button _cs_button--sm _cs_button--positive _cs_m-down--none']"
                },
                GetNumberOfGamesCssSelectorsModel = new GetNumberOfGamesCssSelectorsModel
                {
                    FrameName = "SportFrameScript",
                    PreMatchSelector = "//a[@class='tree-button-component active']//span[@class='count']",
                    LiveMatchSelector = "//a[@class='tree-button-component']//span[@class='count']",
                    WebSiteName = "AdjaraBet",
                },
                CheckBetModel = new CheckBetModel
                {
                    GameBetElement = "//prematch-component[@class='prematch-component competition-component']//span[@class='inner']",
                    SingleBetAmountInputElement = "input[name='bet']",
                    SingleBetAmount = "20",
                    BetBtn = "a[class='bet-btn bet-now']",
                    MultipleBetAmountInputElement = "input[placeholder='min 20']",
                    MultipleBetAmount = "20",
                    WaitAfterBetElement = "//*[text()='Your betslip is empty']"
                }
            });
            PartnerDatas.Add(new PartnerData
            {
                PartnerName = "Efugames",
                HelpUrl = "https://efugames.com/sport/prematch",
                Url = "https://efugames.com/home",
                UserName = "Narek3789",
                Password = "Nar015781993",
                SportButtonSelector = "a[href='/sport/prematch'][ng-reflect-klass='link']",
                LoginCssSelectors = new LoginSelectorsModel
                {
                    LoginFormBtn = "a[class='button-component size-4 ext-1']",
                    UserNameInput = "input[formcontrolname = 'login']",
                    PasswordInput = "input[formcontrolname='pass']",
                    LoginBtn = "button[class='button-component size-2 full ext-2']"
                },
                GetNumberOfGamesCssSelectorsModel = new GetNumberOfGamesCssSelectorsModel
                {
                    FrameName = "sportsbookIframe",
                    PreMatchSelector = "//a[@class='tree-button-component active']//span[@class='count']",
                    LiveMatchSelector = "//a[@class='tree-button-component']//span[@class='count']",
                    WebSiteName = "Efugames"
                },
                CheckBetModel = new CheckBetModel
                {
                    //BetFrameName = "sportsbookIframe",
                    GameBetElement = "//prematch-component[@class='prematch-component competition-component']//span[@class='inner']",
                    SingleBetAmountInputElement = "input[name='bet']",
                    SingleBetAmount = "1",
                    BetBtn = "a[class='bet-btn bet-now']",
                    MultipleBetAmountInputElement = "input[placeholder='min 1']",
                    MultipleBetAmount = "1",
                    WaitAfterBetElement = "//*[text()='your betslip is empty']"
                }
            });
            //PartnerDatas.Add(new PartnerData
            //{
            //    PartnerName = "MalagaBet",
            //    Url = "https://malagabet.es/home",
            //    HelpUrl = "https://malagabet.es/sport/prematch",
            //    UserName = "Narek378",
            //    Password = "Nar015781993",
            //    SportButtonSelector = "a[href='/sport/prematch'][ng-reflect-klass='link']",
            //    LoginCssSelectors = new LoginSelectorsModel
            //    {
            //        LoginFormBtn = "a[class='button-component size-4 ext-1']",
            //        UserNameInput = "input[formcontrolname = 'login']",
            //        PasswordInput = "input[formcontrolname='pass']",
            //        LoginBtn = "button[class='button-component size-2 full ext-2']"
            //    },
            //    GetNumberOfGamesCssSelectorsModel = new GetNumberOfGamesCssSelectorsModel
            //    {
            //        FrameName = "sportsbookIframe",
            //        PreMatchSelector = "//a[@class='tree-button-component active']//span[@class='count']",
            //        LiveMatchSelector = "//a[@class='tree-button-component']//span[@class='count']",
            //        WebSiteName = "MalagaBet"
            //    },
            //    CheckBetModel = new CheckBetModel
            //    {
            //        //BetFrameName = "sportsbookIframe",
            //        GameBetElement = "//prematch-component[@class='prematch-component competition-component']//span[@class='inner']",
            //        SingleBetAmountInputElement = "input[name='bet']",
            //        SingleBetAmount = "1",
            //        BetBtn = "a[class='bet-btn bet-now']",
            //        MultipleBetAmountInputElement = "input[placeholder='min 1']",
            //        MultipleBetAmount = "1",
            //        WaitAfterBetElement = "//*[text()='your betslip is empty']"

            //    }

            //});
            //PartnerDatas.Add(new PartnerData
            //{
            //    PartnerName = "888cashbet",
            //    Url = "https://alpha.888cashbet.com/home",
            //    HelpUrl = "https://alpha.888cashbet.com/sport/prematch/1/INT/1027/2231336",
            //    UserName = "Narek378",
            //    Password = "Nar015781993",
            //    SportButtonSelector = "a[href='/sport/prematch'][ng-reflect-klass='link']",
            //    LoginCssSelectors = new LoginSelectorsModel
            //    {
            //        LoginFormBtn = "a[class='button-component size-4 ext-1']",
            //        UserNameInput = "input[formcontrolname = 'login']",
            //        PasswordInput = "input[formcontrolname='pass']",
            //        LoginBtn = "button[class='button-component size-2 full ext-2']"
            //    },
            //    GetNumberOfGamesCssSelectorsModel = new GetNumberOfGamesCssSelectorsModel
            //    {
            //        FrameName = "sportsbookIframe",
            //        PreMatchSelector = "//a[@class='tree-button-component active']//span[@class='count']",
            //        LiveMatchSelector = "//a[@class='tree-button-component']//span[@class='count']",
            //        WebSiteName = "888cashbet",
            //    },
            //    CheckBetModel = new CheckBetModel
            //    {
            //        //BetFrameName = "sportsbookIframe",
            //        GameBetElement = "//prematch-component[@class='prematch-component competition-component']//span[@class='inner']",
            //        SingleBetAmountInputElement = "input[name='bet']",
            //        SingleBetAmount = "1",
            //        BetBtn = "a[class='bet-btn bet-now']",
            //        MultipleBetAmountInputElement = "input[placeholder='Min 1']",
            //        MultipleBetAmount = "1",
            //        WaitAfterBetElement = "//*[text()='your betslip is empty']"

            //    }

            //});




            {  //
               //PartnerDatas.Add(new PartnerData
               //{
               //    PartnerName = "t3t",
               //    Url = "https://t3t.website/home",
               //});

                //PartnerDatas.Add(new PartnerData
                //{
                //    PartnerName = "efugames",
                //    Url = "https://efugames.com/home,",                
                //});}


                //Task.Run(() => Helpers.TestPartner(partnerData , driver));
                //public static void TestPartner(PartnerData partnerData , IWebDriver driver)
                //{
                //    var loginpage = new LoginPage(driver);

                //    loginpage.open1(partnerData.Url);
                //    loginpage.LogintoMyPage(partnerData.LoginCssSelectors, partnerData.UserName, partnerData.Password);
                //    loginpage.TakeScreenshot(string.Format("{0}Login", partnerData.UserName));
                //    loginpage.GoToSport1(partnerData.SportButtonCssSelector);
                //    loginpage.TakeScreenshot(string.Format("{0}Sport", partnerData.UserName));
                //    loginpage.GetNumberofGames1(partnerData.GetNumberOfGamesCssSelectorsModel);
                //    ((IJavaScriptExecutor)driver).ExecuteScript("window.open()");
                //    driver.SwitchTo().Window(driver.WindowHandles.Last());
                //}}
            }
        }
    }
}
