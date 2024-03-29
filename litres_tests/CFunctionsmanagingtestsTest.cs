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
public class FunctionsmanagingtestsTest {
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
  public void addsubscriptionfun() {
    driver.Navigate().GoToUrl("https://www.litres.ru/");
    driver.FindElement(By.CssSelector(".MoreButton-module__moreButton_t9MXK")).Click();
    driver.FindElement(By.CssSelector(".MoreButton-module__moreButton_t9MXK")).Click();
    driver.FindElement(By.LinkText("Популярные авторы")).Click();
    driver.FindElement(By.CssSelector(".scroll_arts_wrap:nth-child(2) > #default-standart-slider .arts-slider__arts_wrapper__inner")).Click();
    driver.FindElement(By.LinkText("Патрик Кинг")).Click();
    driver.FindElement(By.CssSelector(".Button-module__button_large_391UX .Button-module__textContainer_1I67-")).Click();
    driver.Close();
  }
  [Test]
  public void addpostponefun() {
    driver.Navigate().GoToUrl("https://www.litres.ru/");
    driver.FindElement(By.CssSelector(".NavBar-modules__navBar_19znZ > .Tab-modules__tab_o4eJ7:nth-child(1) .Tab-modules__tab__title_nqb1J")).Click();
    driver.FindElement(By.LinkText("Выбрать книги")).Click();
    driver.FindElement(By.CssSelector(".ArtsGrid-module__artWrapper_1j1xJ:nth-child(2) .LikeButton-module__likeButton_gtG7W:nth-child(1) svg")).Click();
    driver.FindElement(By.CssSelector(".NavBar-modules__navBar_19znZ > .Tab-modules__tab_o4eJ7:nth-child(1) > .Tab-modules__tab__link_3MFWj")).Click();
    driver.Close();
  }
  [Test]
  public void addbasketfun() {
    driver.Navigate().GoToUrl("https://www.litres.ru/popular/");
    driver.FindElement(By.CssSelector(".ArtV2Default-module__wrapper__advertise_1RX2s .ArtInfo-modules__title_1UysF")).Click();
    driver.FindElement(By.CssSelector(".Button-module__button_large_391UX .Button-module__textContainer_1I67-:nth-child(2)")).Click();
    driver.Close();
  }
  [Test]
  public void delpostponefun() {
    driver.Navigate().GoToUrl("https://www.litres.ru/");
    driver.FindElement(By.CssSelector(".NavBar-modules__navBar_19znZ > .Tab-modules__tab_o4eJ7:nth-child(1) svg")).Click();
    driver.FindElement(By.CssSelector(".ContextMenu-module__contextMenu__button__icon_1n-I- > svg")).Click();
    driver.FindElement(By.CssSelector(".ContextMenu-module__contextMenu__item_1mKDE:nth-child(4)")).Click();
    driver.Close();
  }
  [Test]
  public void delbasketfun() {
    driver.Navigate().GoToUrl("https://www.litres.ru/");
    driver.FindElement(By.CssSelector(".Tab-modules__tab_o4eJ7:nth-child(2) > .Tab-modules__tab__link_3MFWj")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".Tab-modules__tab_o4eJ7:nth-child(2) .Tab-modules__tab__title_nqb1J"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.CssSelector(".FunctionalButton-module__funcButton_388-A:nth-child(2) .FunctionalButton-module__funcButtonContent__child_3mjgy:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".Button-module__button_medium_2XZ9k:nth-child(1) .Button-module__textContainer_1I67-")).Click();
    driver.Close();
  }
}
