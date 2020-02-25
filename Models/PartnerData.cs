using NLog;
using System;
using System.Collections.Generic;
using TestPartners.Models;
using TestPartnersPages.Models;

public class PartnerData
{
    private static Logger _logger = LogManager.GetCurrentClassLogger();
    public string PartnerName { get; set; }

    public string Url { get; set; }

    public string HelpUrl { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string SportButtonSelector { get; set; }
    
    public LoginSelectorsModel LoginCssSelectors { get; set; }

    public GetNumberOfGamesCssSelectorsModel GetNumberOfGamesCssSelectorsModel { get; set; }

    public CheckBetModel CheckBetModel { get; set; }

   
    
}
