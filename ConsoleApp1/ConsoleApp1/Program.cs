using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            
            

        }
        [SetUp]
        public void Inicijalizacija()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void Test1()
        {
            IWebElement firstname = driver.FindElement(By.Id("firstName"));
            firstname.SendKeys("Marko");

            IWebElement lastname = driver.FindElement(By.Id("lastName"));
            lastname.SendKeys("Manojlovic");

            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("manojlovicm1510@gmail.com");

            IWebElement male = driver.FindElement(By.ClassName("custom-control-label"));
            male.Click();

            IWebElement mobilenumber = driver.FindElement(By.Id("userNumber"));
            mobilenumber.SendKeys("0611462727");

            // Pokusao sam da izaberem i datum ovo je jedan nacin
            //IWebElement datum = driver.FindElement(By.Id("dateOfBirthInput"));
            //driver.FindElement(By.ClassName("react-datepicker__day react-datepicker__day--015 react-datepicker__day--selected")).Click();
            
            // A ovo je pokusaj za predmet ovo je drugi nacin, samo mi fali kako da potvrdim ono sto je ukucano tipa enter
            //IWebElement subject = driver.FindElement(By.ClassName("subjects-auto-complete__value-container subjects-auto-complete__value-container--is-multi css-1hwfws3"));
            //subject.SendKeys("Maths");
            // subject.Click();
             
             

            IWebElement sports = driver.FindElement(By.ClassName("custom-control-label"));
            sports.Click();

        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
        
         
    }
}
