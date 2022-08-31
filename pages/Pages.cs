using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Desafio_QA_Buildbox.pages;

public class Pages
{
    public IWebDriver driver;

    public Pages(IWebDriver driver)
    {
        this.driver = driver;
    }

    //This method will create a list of web elements by tag name and return this list.
    public List<IWebElement> CreateListOfElementsByTagName(IWebElement fatherElement, string ElementTagName)
    {
        List<IWebElement> listOfElements = new List<IWebElement>();

        foreach (IWebElement element in fatherElement.FindElements(By.TagName(ElementTagName)))
        {
            listOfElements.Add(element);
        }

        return listOfElements;
    }

    //This method will create a list of web elements by class name and return this list.
    public List<IWebElement> CreateListOfElementsByClassName(IWebElement fatherElement, string ElementClassName)
    {
        List<IWebElement> listOfElements = new List<IWebElement>();

        foreach (IWebElement element in fatherElement.FindElements(By.CssSelector(ElementClassName)))
        {
            listOfElements.Add(element);
        }

        return listOfElements;
    }

    //This method will create a list of web elements and choose one element in this list and click on it.
    public void CreateListAndChooseOne(IWebElement fatherElement, string ElementTagName, string myChoice_text)
    {
        List<IWebElement> elementsList = CreateListOfElementsByTagName(fatherElement, ElementTagName);

        if (elementsList.Count == 0)
            System.Console.WriteLine("There's no elements in the list");

        // elementsList[Convert.ToInt32(myChoice_text)].Click();

        foreach (IWebElement element in elementsList)
        {
            if (element.Text == myChoice_text)
            {
                element.Click();
            }
        }
    }

    //This method will create a list of web elements and return how many elements this list contains.
    public int CountHowManyElementsExists(IWebElement fatherElement, string ElementTagName)
    {
        List<IWebElement> listOfElements = CreateListOfElementsByTagName(fatherElement, ElementTagName);

        return listOfElements.Count;
    }

    //This method will create a list of web elements and return how many elements this list contains.
    public int CountHowManyElementsExistsByClassName(IWebElement fatherElement, string ElementClassName)
    {
        List<IWebElement> listOfElements = CreateListOfElementsByClassName(fatherElement, ElementClassName);

        return listOfElements.Count;
    }
}