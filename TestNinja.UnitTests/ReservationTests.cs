using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});

            // Assert 
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            //Arrange
            var user123 = new User();
            var reservation = new Reservation {MadeBy = user123};

            //Act
            var result = reservation.CanBeCancelledBy(user123);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReturn_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User() };            

            //Act
            var result = reservation.CanBeCancelledBy( new User() );

            //Assert
            Assert.IsFalse(result);
        }
    }
}
