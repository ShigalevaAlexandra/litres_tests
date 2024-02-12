using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace litres_tests
{
    public class Tests
    {
        //определение переменной для работы с браузером
        private IWebDriver driver;

        [SetUp]

        //переход по созданной переменной на страницу WEB-приложения
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.litres.ru/");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown] 
        public void TearDown() 
        { 

        }
    }
}