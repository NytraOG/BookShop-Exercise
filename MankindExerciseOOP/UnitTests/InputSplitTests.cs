﻿using System;
using ClassLib;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
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
            string inputString = "Berthram Bobsen 36489";
            int arrayCountExpected = 3;
            
            //Act
            var stringManager = new StringManager(inputString);

            //Assert
            Assert.AreEqual(arrayCountExpected, stringManager.SplitString().Count);
        }

        [TestMethod]
        public void ChecktDieAnzahlDerStringsNachDemSplitWorker()
        {
            //Arrange
            string inputString = "Charlotte Clein 1500 9";
            int arrayCountExpected = 4;

            //Act
            var stringManager = new StringManager(inputString);

            //Assert
            Assert.AreEqual(arrayCountExpected, stringManager.SplitString().Count);
        }

        [TestMethod]
        public void IchGuckeObNachDemSplitDerStringInEinenDecimaloderIntGewandeltWordenist()
        {
            //Arrange
            string inputString = "Kevin Klein 2668 8";

            string firstNameExpected = "Kevin";
            string lastNameExpected = "Klein";
            decimal weeklySalaryExpected = 2668;
            int workHoursPerDayExpected = 8;

            //Act
            var stringManager = new StringManager(inputString);
            var testList = stringManager.SplitString();

            //Assert
            Assert.AreEqual(firstNameExpected, testList[0]);
            Assert.AreEqual(lastNameExpected, testList[1]);
            Assert.AreEqual(weeklySalaryExpected, testList[2]);
            Assert.AreEqual(workHoursPerDayExpected, testList[3]);
        }
    }
}
