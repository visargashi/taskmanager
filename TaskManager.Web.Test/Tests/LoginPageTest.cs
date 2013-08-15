#region

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using TaskManager.Web.Test.Pages;
using Xunit;

#endregion

namespace TaskManager.Web.Test.Tests
{
    public class LoginPageTest : IDisposable
    {
        [Fact]
        public void TestNavigateToLogin()
        {
            var loginPage = new LogInPage();
            loginPage.Goto();
            Assert.True(loginPage.IsAt());
        }

        [Fact]
        public void TestLogin()
        {
            var loginPage = new LogInPage();
            loginPage.Goto();

            loginPage.Username = "test";
            loginPage.Password = "testing";
            loginPage.Submit();

            Thread.Sleep(1000);

            var button = Browser.Driver.FindElement(By.ClassName("add-todo-btn")); 

            Assert.True(button != null);
        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}