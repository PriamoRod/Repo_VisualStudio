using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        RemoteWebDriver driver;
        public UnitTest1()
        {
            driver = new ChromeDriver(@"C:\Users\pconcepcio\Desktop\Importador de Casos\App\");
        }

        [Fact]
        public void Test1( )
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            var element = driver.FindElement(By.Name("q"));

            element.SendKeys("Hello world");
            element.SendKeys(Keys.Enter);

            //var button = driver.FindElement(By.Name("btnK"));
            //button.Click();

            var stats = driver.FindElement(By.Id("result-stats"));
            Assert.Equal("Cerca de 1,430,000,000 resultados", stats.Text);

        }
    }
}
