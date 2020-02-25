using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartnersPages.Models
{
    public class GetNumberOfGamesCssSelectorsModel
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public string FrameName { get; set; }

        public string PreMatchSelector { get; set; }

        public string LiveMatchSelector { get; set; }

        public string WebSiteName { get; set; }
    }
}
