using NasaDemo.NasaHelper;
using NasaDemo.NasaPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NasaDemo.NasaStepDefinition
{
    [Binding]
    public sealed class StepDefinition1
    {
        private NasaHomePage hp;
        private NasaGenerateApi nga;



        [Given(@"i navigate to nasa homepage")]
        public void GivenINavigateToNasaHomepage()
        {
            hp = BaseClass.GivenINavigatetoNasaPage();
        }

        [Given(@"input ""(.*)"" input ""(.*)"" input ""(.*)""")]
        public void GivenInputInputInput(string FirstName, string LastName, string Email)
        {
            hp.Inputfirst(FirstName);
            hp.Inputlast(LastName);
            hp.InputEmail(Email);
            
        }

        [When(@"i click on Signup button")]
        public void WhenIClickOnSignupButton()
        {
            nga = hp.ClickSigncta();
        }

        [Then(@"i am on api generation page")]
        public void ThenIAmOnApiGenerationPage()
        {
           
        }




    }
}
