using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow.DrivingDemo.Test.Steps
{
    [Binding]
    public class DrivingAgeSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IDrivingRegulations _drivingRegulations;

        public DrivingAgeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _drivingRegulations = new DrivingRegulations();
        }

        [Given(@"The driver is (\d+) years old")]
        public void GivenTheDriverIsYearsOld(int age)
        {
            _scenarioContext["Person"] = new Person { FirstName = "", Age = age };
        }
        
        [When(@"they live in (.*)")]
        public void WhenTheyLiveInSwitzerland(string countryName)
        {
            var country = Enum.Parse<Country>(countryName);
            var person = (Person)_scenarioContext["Person"];

            _scenarioContext["Result"] = _drivingRegulations.IsAllowedToDrive(person, country);
        }
        
        [Then(@"they are permitted to drive")]
        public void ThenTheyArePermittedToDrive()
        {
            var result = (bool)_scenarioContext["Result"];
            Assert.IsTrue(result);
        }

        [Then(@"they are not permitted to drive")]
        public void ThenTheyAreNotPermittedToDrive()
        {
            var result = (bool)_scenarioContext["Result"];
            Assert.IsFalse(result);
        }
    }
}
