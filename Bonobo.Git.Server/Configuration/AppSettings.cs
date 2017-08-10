using System;
using System.Configuration;
using System.Globalization;

namespace Bonobo.Git.Server.Configuration
{
    public static class AppSettings
    {
        public static bool IsPushAuditEnabled
        {
            get
            {
                return bool.Parse(ConfigurationManager.AppSettings["IsPushAuditEnabled"] ?? "false");
            }
        }

        public static string StandardDateTimeFormat
        {
            get
            {
                return String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["StandardDateTimeFormat"]) 
                    ? $"{DateTimeFormatInfo.CurrentInfo.ShortDatePattern} {DateTimeFormatInfo.CurrentInfo.LongTimePattern}" 
                    : ConfigurationManager.AppSettings["StandardDateTimeFormat"];
            }
        }
    }
}