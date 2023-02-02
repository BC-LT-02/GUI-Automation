using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Todo.Utilities;

public class Driver
{
    public IWebDriver? _driver;

    [OneTimeSetUp]
    public void Setup()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
        _driver.Navigate().GoToUrl("https://todo.ly/");
    }

    [OneTimeTearDown]
    public void Teardown()
    {
        _driver!.Close();
        _driver.Quit();
    }
}
