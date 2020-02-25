using NLog;

namespace TestPartnersPages.Models
{
    public class CheckBetModel
     {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        //public string BetFrameName { get; set; }
        public string GameBetElement { get; set; }
        public string SingleBetAmountInputElement { get; set; }
        public string BetBtn { get; set; }
        public string SingleBetAmount { get; set; }
        public string MultipleBetAmountInputElement { get; set; }
        public string MultipleBetAmount { get; set; }
        public string WaitAfterBetElement { get; set; }

    }
}
