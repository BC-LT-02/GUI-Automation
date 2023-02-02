using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Todo.Utilities;

public class ProgramTodo
{
    public static void newProject(IWebDriver _driver, string keys)
    {
        //NEW PROJECT
        var newProject = _driver!.FindElement(By.XPath("//td[text()='Add New Project']"));
        newProject.Click();
        var inputNewProject = _driver.FindElement(By.Id("NewProjNameInput"));
        inputNewProject.SendKeys("This is a new project");
        var buttonNewProject = _driver.FindElement(By.Id("NewProjNameButton"));
        buttonNewProject.Click();
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

    public static void newNote(IWebDriver _driver, string keys)
    {
        //NEW NOTE
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        var newNote = _driver.FindElement(
            By.XPath(
                "//div[@class='MainTableRightDiv']//div[@id='MainContentArea' and div[text()='This is a new project']]/following-sibling::div[@class='AddNewItemDiv']//textarea[@id='NewItemContentInput']"
            )
        );
        newNote.SendKeys("This is a new note");
        var addNote = _driver.FindElement(By.Id("NewItemAddButton"));
        addNote.Click();
    }

    public static void doneNote(IWebDriver _driver, string keys)
    {
        //MARK NOTE AS DONE
        var itemCheckBox = _driver.FindElement(
            By.XPath("//div[@id='ItemListPlaceHolder']//input[@class='ItemCheckBox']")
        );
        itemCheckBox.Click();
    }
}
