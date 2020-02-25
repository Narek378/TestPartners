using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartnersPages.Models
{
    public class LoginSelectorsModel
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public string LoginFormBtn { get; set; }
        public string UserNameInput { get; set; }
        public string PasswordInput { get; set; }
        public string LoginBtn { get; set; }
    }
}
