﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace VehicleForIYASAKA
{
    /// <summary>
    /// Summary description for VehicleForIYASAKAService_ZJ
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VehicleForIYASAKAService_ZJ : System.Web.Services.WebService
    {

        [WebMethod]
         public string queryObjectOut(string jczbh, string jkid, string xmlDoc)
        {
            

            return "";
        }

    }
}
