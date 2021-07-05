using NasaDemo.NasaHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NasaDemo.NasaPages
{
    public class NasaHomePage:BaseClass
    {
        IWebElement FirstName = driver.FindElement(By.Id("user_first_name"));
        IWebElement LastName = driver.FindElement(By.Id("user_last_name"));
        IWebElement Email = driver.FindElement(By.Id("user_email"));
        IWebElement SignUp = driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary"));



        public void Inputfirst(string Fn)
        {

            var element = driver.FindElement(By.Id("user_first_name"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);

            FirstName.SendKeys(Fn);
            
        }

        public void Inputlast(string Ln)
        {
            LastName.SendKeys(Ln);
        }

        public void InputEmail(string Em)
        {
            Email.SendKeys(Em);
            Thread.Sleep(100);
        }

        public NasaGenerateApi ClickSigncta()
        {
            SignUp.Click();
            return new NasaGenerateApi();

            
        }
    }
}
