using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        // 3 scenarios
        // 3 execution paths in that method (3 return possibilities) 
        // convention part 1: name of method to test _  part 2: scenario testing _  part 3: expected behavior 
        public void NameOfMethodToTest_Scenario_ExpectedBehavior()
        {
            //convention is called "triple A / AAA" or it's called "Arrange, Act, Assert".

            // Arrange

            // Act

            // Assert 
        }
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
        }
        public void CanBeCancelledBy_Scenario_ExpectedBehavior2()
        {
        }
        public void CanBeCancelledBy_Scenario_ExpectedBehavior3()
        {
        }
    }
}
