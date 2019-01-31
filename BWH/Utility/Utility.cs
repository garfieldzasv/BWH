using System;
using System.Collections.Specialized;
using System.Configuration;

namespace BandwagonHelper
{
    public class Utility
    {
        public static DateTime UnixTimeStampToDateTime(decimal unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(Convert.ToDouble(unixTimeStamp)).ToLocalTime();
            return dateTime;
        }

        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static void SetSetting(NameValueCollection keyValuePair)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (string key in keyValuePair.AllKeys)
            {
                configuration.AppSettings.Settings[key].Value = keyValuePair[key];
            }
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
