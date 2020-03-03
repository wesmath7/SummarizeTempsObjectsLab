using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummarizeTempsObjects;
using System.Collections.Generic;

namespace EngineTests
{
    [TestClass]
    public class TempCalculationEngineTests
    {
        List<int> testTemps = new List<int>();

        /// <summary>
		/// Initialize the list of temps to be used in the tests
		/// </summary>
        [TestInitialize]
        public void Initialize()
        {
            // add a bunch of temps to the test list
            testTemps.Add(10);
            testTemps.Add(20);
            testTemps.Add(30);
            testTemps.Add(40);
            testTemps.Add(50);
            testTemps.Add(60);
            testTemps.Add(70);
        }

        /// <summary>
		/// Test the average temperature calculation
		/// </summary>
        [TestMethod]
        public void TempCalculationEngine_AverageTemp()
        {
            // arrange
            TempCalculationEngine engine = new TempCalculationEngine(testTemps);

            // act
            int result = engine.AverageTemperature();

            // assert
            Assert.AreEqual(40, result);
        }

        /// <summary>
		/// Test the calculation of temperatures above the provided threshold
		/// </summary>
        [TestMethod]
        public void TempCalculationEngine_AboveThreshold()
        {
            // arrange
            TempCalculationEngine engine = new TempCalculationEngine(testTemps);

            // act
            int result = engine.TempsAboveThreshold(30);

            // assert
            Assert.AreEqual(4, result);
        }

        /// <summary>
		/// Test the calculation of temperatures below the provided threshold
		/// </summary>
        [TestMethod]
        public void TempCalculationEngine_BelowThreshold()
        {
            // arrange
            TempCalculationEngine engine = new TempCalculationEngine(testTemps);

            // act
            int result = engine.TempsBelowThreshold(30);

            // assert
            Assert.AreEqual(2, result);
        }

        /// <summary>
		/// Test the calculation of temperatures at the provided threshold
		/// </summary>
        [TestMethod]
        public void TempCalculationEngine_AtThreshold()
        {
            // arrange
            TempCalculationEngine engine = new TempCalculationEngine(testTemps);

            // act
            int result = engine.TempsAtThreshold(30);

            // assert
            Assert.AreEqual(1, result);
        }

        /// <summary>
		/// Test the calculation of the number of temperatures in the list
		/// </summary>
        [TestMethod]
        public void TempCalculationEngine_Number()
        {
            // arrange
            TempCalculationEngine engine = new TempCalculationEngine(testTemps);

            // act
            int result = engine.NumberOfTemperatures();

            // assert
            Assert.AreEqual(7, result);
        }
    }
}
