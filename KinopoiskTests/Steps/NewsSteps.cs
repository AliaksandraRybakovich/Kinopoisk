using KinopoiskTests.Entities;
using KinopoiskTests.Pages;

namespace KinopoiskTests.Steps
{
    public class NewsSteps
    {
        static NewsPage newsPage = new NewsPage();

        public static void ClickOnData(DataNewsInfo dataNews)
        {
            foreach (var day in newsPage.Day)
            {
                if (day.Text == dataNews.Day)
                {
                    day.Click();
                    break;
                }
            }
        }

        public static bool AssertCollectionNews(DataNewsInfo dataNews)
        {
            bool isAssert = true;
            foreach (var data in newsPage.NewsData)
            {
                string[] array = data.Text.Split('.');
                if ((array[0] != dataNews.Day) && (array[1] != dataNews.Month) && (array[2] != dataNews.Year))
                {
                    isAssert = false;
                    break;
                }
            }
            return isAssert;
        }
    }
}
