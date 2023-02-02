using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Todo.Utilities;

public class Settings
{
    public Settings()
    {
        DotNetEnv.Env.TraversePath().Load();
    }

    public static void login(IWebDriver _driver)
    {
        string? email = Environment.GetEnvironmentVariable("EMAIL");
        string? password = Environment.GetEnvironmentVariable("PASSWORD");

        //LOGIN
        var loginButton = _driver!.FindElement(By.XPath("//div[@class='HPHeaderLogin']"));
        loginButton.Click();
        var Username = _driver.FindElement(
            By.XPath("//input[@name='ctl00$MainContent$LoginControl1$TextBoxEmail']")
        );
        Username.SendKeys(email);
        var Password = _driver.FindElement(
            By.XPath("//input[@name='ctl00$MainContent$LoginControl1$TextBoxPassword']")
        );
        Password.SendKeys(password);
        var loginWithCredentials = _driver.FindElement(
            By.XPath("//input[@name=('ctl00$MainContent$LoginControl1$ButtonLogin')]")
        );
        loginWithCredentials.Click();
    }
}
