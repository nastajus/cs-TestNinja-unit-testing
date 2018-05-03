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
        public void CanBeCancelledBy_MadeByUser123_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            var user123 = new User { IsAdmin = false };
            reservation.MadeBy = user123;

            //Act
            var result = reservation.CanBeCancelledBy(user123);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_Nobody_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();
            var user123 = new User { IsAdmin = false };

            //Act
            var result = reservation.CanBeCancelledBy(user123);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
