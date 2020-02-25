using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPartners.Models
{
    class CheckPresence
    {
        public static bool Check(IWebDriver driver,string element)
        {
            bool present;
            try
            {
                driver.FindElement(By.CssSelector(element));
                present = true;
            }
            catch (NoSuchElementException e)
            {
                present = false;
            }
            return present;
        }


    }
}
