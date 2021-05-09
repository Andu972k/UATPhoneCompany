using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UATPhoneCompany.Steps
{
    [Binding]
    public sealed class DepotStepDefinition
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public DepotStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        #region Given

        [Given("the hardware name is '(.*.\\w)'")]
        public void GivenTheHardwareNameIs(string hardwareName)
        {
            _scenarioContext.Pending();
        }

        [Given("the requested amount is (.*)")]
        public void GivenTheRequestedAmountIs(int requestedAmount)
        {
            _scenarioContext.Pending();
        }

        [Given("the destination is '(.*.\\w)'")]
        public void GivenTheDestinationIs(string destination)
        {
            _scenarioContext.Pending();
        }

        [Given("the depot storage quantity is greater than the requested amount")]
        public void GivenTheDepotStorageIsGreaterThanTheRequestedAmount()
        {
            _scenarioContext.Pending();
        }

        [Given("the depot storage quantity is less than the requested amount")]
        public void GivenTheDepotStorageIsLessThanTheRequestedAmount()
        {
            _scenarioContext.Pending();
        }

        [Given("the item exists")]
        public void GivenTheItemExists()
        {
            _scenarioContext.Pending();
        }

        [Given("the item does not exist")]
        public void GivenTheItemDoesNotExist()
        {
            _scenarioContext.Pending();
        }


        #endregion

        #region When

        [When("I request the transfer of hardware")]
        public void WhenIRequestTheTransferOfHardware()
        {
            _scenarioContext.Pending();
        }

        [When("I order the new material")]
        public void WhenIOrderTheNewMaterial()
        {
            _scenarioContext.Pending();
        }

        [When("I attempt to check the depot's stock for the item")]
        public void WhenIAttemptToCheckTheDepotsStocksForTheItem()
        {
            _scenarioContext.Pending();
        }

        #endregion


        #region Then

        [Then("the depot should respond with a successful message")]
        public void ThenTheDepotShouldRespondWithASuccessfulMessage()
        {
            _scenarioContext.Pending();
        }

        [Then("the depot should respond with an unsuccessful message")]
        public void ThenTheDepotShouldRespondWithAnUnSuccessfulMessage()
        {
            _scenarioContext.Pending();
        }

        #endregion






        //[Given("the first number is (.*)")]
        //public void GivenTheFirstNumberIs(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //    _scenarioContext.Pending();
        //}

        //[Given("the second number is (.*)")]
        //public void GivenTheSecondNumberIs(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //    _scenarioContext.Pending();
        //}

        //[When("the two numbers are added")]
        //public void WhenTheTwoNumbersAreAdded()
        //{
        //    //TODO: implement act (action) logic

        //    _scenarioContext.Pending();
        //}

        //[Then("the result should be (.*)")]
        //public void ThenTheResultShouldBe(int result)
        //{
        //    //TODO: implement assert (verification) logic

        //    _scenarioContext.Pending();
        //}
    }
}
