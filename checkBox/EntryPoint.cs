using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
class EntryPoint

{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement? textBox;
    static void Main()

    {
        string url = "https://automationintesting.com/selenium/testpage/";
        driver.Navigate().GoToUrl(url);
        textBox = driver.FindElement(By.CssSelector("#firstname"));
        textBox.SendKeys("sheno emailin test");
        Thread.Sleep(3000);

        driver.Quit();



    }// ok
}

