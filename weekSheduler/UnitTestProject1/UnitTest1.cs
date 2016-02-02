using System;
using weekSheduler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArrangeFalse()
        {
            // arrange
            Days plans = Days.Monday | Days.Tuesday;
            WeekSheduler organizer = new WeekSheduler();

            // act

            var result = organizer.ArrangeDay(ref plans, Days.Monday);

            // assert

            Assert.AreEqual(false, result); 
        }


        [TestMethod]
        public void TestArrangeTrue()
        {
            // arrange
            Days plans = Days.Monday | Days.Tuesday;
            WeekSheduler organizer = new WeekSheduler();

            // act

            var result = organizer.ArrangeDay(ref plans, Days.Wednesday);

            // assert

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestCheckFalse()
        {
            // arrange
            Days plans = Days.Monday | Days.Tuesday;
            WeekSheduler organizer = new WeekSheduler();

            // act

            var result = organizer.CheckDay(plans, Days.Wednesday);

            // assert

            Assert.AreEqual(false, result);
        }



        [TestMethod]
        public void TestCheckTrue()
        {
            // arrange
            Days plans = Days.Monday | Days.Tuesday;
            WeekSheduler organizer = new WeekSheduler();

            // act

            var result = organizer.CheckDay(plans, Days.Monday);

            // assert

            Assert.AreEqual(true, result);
        }
    }
}
