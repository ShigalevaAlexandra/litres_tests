using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace litres_tests
{
    public class Tests
    {
        //����������� ���������� ��� ������ � ���������
        private IWebDriver driver;

        [SetUp]

        //������� �� ��������� ���������� �� �������� WEB-����������
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