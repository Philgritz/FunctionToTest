using FunctionToTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace FunctionToTest_TestProject {

    [TestClass]
    public class UnitTest1 {

        ForecastingFunction ff = null;

        [TestInitialize]
        public void TestInit() {
            ff = new ForecastingFunction();  //allows to create instance just 1 time
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestParmsOutsideDomain() {
            ff.Multiplier = 0;
                Assert.AreEqual(0, ff.Forecast(100, 100));


        }

        [TestMethod]
        public void TestValidInputwithMultiplierZero() {
            //Multiplier is zero
            ff.Multiplier = 0;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(1, 1), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");



            // test Multiplier of 2, x of 2, y of 2, result 24
            ff.Multiplier = 2;
            var result = ff.Forecast(2, 2);
            Assert.AreEqual(24, result);
            ff.Multiplier = 3;
            Assert.AreEqual(36, ff.Forecast(2, 2), "Result should be 36");
        }
        [TestMethod]
        public void TestValidInputsWithMultiplierOne() {
            //Multiplier is one
            ff.Multiplier = 1;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(2, ff.Forecast(1, 1), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");

        }

        [TestMethod]
        public void TestValidInputsWithMultiplierFive() {
            //Multiplier is five
            ff.Multiplier = 5;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(10, ff.Forecast(1, 1), "Result should be 10");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");
            Assert.AreEqual(60, ff.Forecast(2, 2), "Result should be zero");
            Assert.AreEqual(-20, ff.Forecast(-2, -2), "Result should be zero");
            Assert.IsTrue(ff.Multiplier % 5 == 0);

        }
        public void Test() {
        }
    }
}
