#region

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

#endregion

namespace TaskManager.Web.Test.Pages
{
    public static class Browser
    {
        private static readonly IWebDriver WebDriver = new FirefoxDriver();

        public static string Title
        {
            get { return WebDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return WebDriver; }
        }

        public static void Goto(string url)
        {
            WebDriver.Url = url;
        }

        public static void Close()
        {
            WebDriver.Close();
        }
    }
}