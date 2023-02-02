using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Todo.Utilities;
using NUnit.Framework;

namespace Todo.Test;

public class Tests : Driver
{
    private ProgramTodo Todo = new ProgramTodo();
    private Settings Settings = new Settings();

    [Test]
    public void AddNewProject()
    {
        NewProject.newProject(_driver!, "Automation");
    }
}
