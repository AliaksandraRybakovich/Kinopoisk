using System;
using System.Configuration;

namespace KinopoiskTests.Browser
{
    public class Configuration
    {
        private static string _defaultUserInfoCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForLogin.csv";

        private static string _defaultExtentedSearchCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForExtendedSearch.csv";

        private static string _defaultDataNewsCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForNews.csv";

        private static string _defaultUrlsPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\Urls.csv";


        private static string _session_id = "3%3A1552844385.5.0.1552844385564%3AAQAAfw%3AE5.1%7C1110000015690266.-1.0%7C30%3A179248.996803.v5ZYiWYOwLVpzVCmym4KgjFpvUg";


        public static string Browser => GetEnviromentKey("Browser", "Chrome");

        public static string Url => GetEnviromentKey("Url", _defaultUrlsPath);

        public static string UserInfoCsvPath => GetEnviromentKey("UserInfoCsvPath", _defaultUserInfoCsvPath);

        public static string ExtentedSearchInfoCsvPath => GetEnviromentKey("UserInfoCsvPath", _defaultExtentedSearchCsvPath);

        public static string DataNewsCsvPath => GetEnviromentKey("DataNewsCsvPath", _defaultDataNewsCsvPath);

        public static string SessionID => GetEnviromentKey("Session_Id", _session_id);

        public static string GetEnviromentKey(string key, string defaultValue)
        {
            return ConfigurationManager.AppSettings[key] ?? defaultValue;
        }
    }
}
