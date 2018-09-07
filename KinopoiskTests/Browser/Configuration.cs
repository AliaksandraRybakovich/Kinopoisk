using System.Configuration;

namespace KinopoiskTests.Browser
{
    public class Configuration
    {        
        public static string Browser => GetEnviromentKey("Browser", "Chrome");

        public static string Url = GetEnviromentKey("Url", "https://www.kinopoisk.ru/");
        public static string GetEnviromentKey(string key, string defaultValue)
        {
            return ConfigurationManager.AppSettings[key] ?? defaultValue;
        }
    }
}
