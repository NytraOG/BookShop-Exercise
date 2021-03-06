﻿using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InputSplitTests
    {
        [TestMethod]
        public void ChecktDieAnzahlDerStringsNachDemSplitStudent()
        {
            //Arrange
            const string inputString = "Berthram Bobsen 36489";
            const int arrayCountExpected = 3;
            
            //Act
            var stringManager = new StringManager();

            //Assert
            Assert.AreEqual(arrayCountExpected, stringManager.SplitString(inputString).Count);
        }

        [TestMethod]
        public void ChecktDieAnzahlDerStringsNachDemSplitWorker()
        {
            //Arrange
            const string inputString = "Charlotte Clein 1500 9";
            const int arrayCountExpected = 4;

            //Act
            var stringManager = new StringManager();

            //Assert
            Assert.AreEqual(arrayCountExpected, stringManager.SplitString(inputString).Count);
        }

        [TestMethod]
        public void IchGuckeObNachDemSplitDerStringInEinenDecimaloderIntGewandeltWordenist()
        {
            //Arrange
            const string inputString = "Kevin Klein 2668 8";

            const string firstNameExpected = "Kevin";
            const string lastNameExpected = "Klein";
            const decimal weeklySalaryExpected = 2668;
            const int workHoursPerDayExpected = 8;

            //Act
            var stringManager = new StringManager();
            var testList = stringManager.SplitString(inputString);

            //Assert
            Assert.AreEqual(firstNameExpected, testList[0]);
            Assert.AreEqual(lastNameExpected, testList[1]);
            Assert.AreEqual(weeklySalaryExpected, testList[2]);
            Assert.AreEqual(workHoursPerDayExpected, testList[3]);
        }
    }
}
