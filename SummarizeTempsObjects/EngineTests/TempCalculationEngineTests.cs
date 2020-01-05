using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummarizeTempsObjects;
using System.Collections.Generic;

namespace EngineTests
{
    [TestClass]
    public class TempCalculationEngineTests
    {
        List<int> testTemps = new List<int>();

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

        [TestMethod]
        public void TempCalculationEngine_Test1()
        {
            // arrange

            // act

            // assert
        }
    }
}
