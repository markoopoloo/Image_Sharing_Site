using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace Image_Sharing_Site.App_Code
{
    public class ConnectionString
    {
        private static string text = @"Data Source=(LocalDB)\v11.0;
        AttachDbFilename=|DataDirectory|\ImageSharingSite.mdf;
        Integrated Security=True;Connect Timeout=30";

        public static string Text
        {
            get { return text; }
        }

    }

    
}