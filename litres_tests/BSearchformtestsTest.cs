// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class BSearchformtestsTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void genresearch() {
    driver.Navigate().GoToUrl("https://www.litres.ru/");
    driver.FindElement(By.Name("q")).Click();
    driver.FindElement(By.Name("q")).SendKeys("классика");
    driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
    driver.Close();
  }
  [Test]
  public void authorsearch() {
    driver.Navigate().GoToUrl("https://www.litres.ru/");
    driver.FindElement(By.Name("q")).Click();
    driver.FindElement(By.Name("q")).SendKeys("Лермонтов");
    driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
    driver.Close();
  }
  [Test]
  public void titlesearch() {
    driver.Navigate().GoToUrl("https://www.litres.ru/");
    driver.FindElement(By.Name("q")).Click();
    driver.FindElement(By.Name("q")).SendKeys("451 градус по фаренгейту");
    driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
    driver.Close();
  }
}
