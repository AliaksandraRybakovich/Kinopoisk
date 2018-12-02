using System;
using System.Configuration;

namespace KinopoiskTests.Browser
{
    public class Configuration
    {
        private static string _defaultUserInfoCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForUser.csv";

        private static string _defaultExtentedSearchCsvPath = $"{AppDomain.CurrentDomain.BaseDirectory}..\\..\\Resources\\TestDataForExtendedSearch.csv";

        public static string Browser => GetEnviromentKey("Browser", "Chrome");

        public static string Url => GetEnviromentKey("Url", "https://www.kinopoisk.ru/");

        public static string UserInfoCsvPath => GetEnviromentKey("UserInfoCsvPath", _defaultUserInfoCsvPath);

        public static string ExtentedSearchInfoCsvPath => GetEnviromentKey("UserInfoCsvPath", _defaultExtentedSearchCsvPath);

        public static string GetEnviromentKey(string key, string defaultValue)
        {
            return ConfigurationManager.AppSettings[key] ?? defaultValue;
        }
    }
}
