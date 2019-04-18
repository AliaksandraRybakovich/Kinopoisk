using System;
using System.Configuration;

namespace KinopoiskTests.Browser
{
    public class Configuration
    {
        private static string _defaultUserInfoCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForLogin.csv";

        private static string _defaultExtentedSearchCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForExtendedSearch.csv";

        private static string _defaultDataNewsCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForNews.csv";

        private static string _defaultDataCookiesPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\Cookies.json";

        
        public static string Browser => GetEnviromentKey("Browser", "Chrome");
        
        public static string UserInfoCsvPath => GetEnviromentKey("UserInfoCsvPath", _defaultUserInfoCsvPath);

        public static string ExtentedSearchInfoCsvPath => GetEnviromentKey("UserInfoCsvPath", _defaultExtentedSearchCsvPath);

        public static string DataNewsCsvPath => GetEnviromentKey("DataNewsCsvPath", _defaultDataNewsCsvPath);

        public static string CookiesPath => GetEnviromentKey("Cookies", _defaultDataCookiesPath);

        public static string GetEnviromentKey(string key, string defaultValue)
        {   
            return ConfigurationManager.AppSettings[key] ?? defaultValue;
   
        }
    }
}
