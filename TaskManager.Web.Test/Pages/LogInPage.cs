using OpenQA.Selenium;

namespace TaskManager.Web.Test.Pages
{
    public class LogInPage : Page
    {
        private string _password;

        public string Username
        {
            get { return Browser.Driver.FindElement(By.Id("loginName")).GetAttribute("value"); }
            set
            {
                Browser.Driver.FindElement(By.Id("loginName")).Clear();
                Browser.Driver.FindElement(By.Id("loginName")).SendKeys(value);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                Browser.Driver.FindElement(By.Id("Password")).Clear();
                Browser.Driver.FindElement(By.Id("Password")).SendKeys(value);
            }
        }

        public override string Title
        {
            get { return "My Todo List - My ASP.NET MVC Application"; }
        }

        public override string Url
        {
            get { return BaseUrl; }
        }

        public void Submit()
        {
            Browser.Driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
    }
}