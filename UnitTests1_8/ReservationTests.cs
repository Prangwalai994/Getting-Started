using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingAlltheExecutionTest1_8.Fundamentals;

namespace UnitTests1_8
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
            public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
            {
                //Arrage
                var reservation = new Reservation();

                //Act
                var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

                //Assert

                Assert.IsTrue(result);
            }
            public void CanBeCancelledBy_SameUserCancellingTheReservation_Return()
            {
                var user = new User();
                var reservation = new Reservation { MadeBy = user };

                var result = reservation.CanBeCancelledBy(user);

                Assert.IsTrue(result);
            }
            [TestMethod]
            public void CanBeCancelledBy_AnotherUserCancellingReservation_RetureFalse()
            {
                var reservation = new Reservation { MadeBy = new User() };

                var result = reservation.CanBeCancelledBy(new User());

                Assert.IsFalse(result);
            }
    }
}

