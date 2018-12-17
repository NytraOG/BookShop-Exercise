using System;
using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class NameAlgorithmTests
    {
        [TestMethod]
        public void FirstLetterOfFirstNameToUpperCaseCheck()
        {
            //Arrange
            string firstNameInput = "benjamin";
            string firstNameOutputExpected = "Benjamin";

            //Act
            var testMensch = new Human(firstNameInput,"Becher");

            //Assert
            Assert.AreEqual(firstNameOutputExpected,testMensch.FirstName);
        }

        [TestMethod]
        public void FirstLetterOfLastNameToUpperCaseCheck()
        {
            //Arrange
            string lastNameInput = "becher";
            string lastNameOutputExpected = "Becher";

            //Act
            var testMensch = new Human("Benjamin", lastNameInput);

            //Assert
            Assert.AreEqual(lastNameOutputExpected, testMensch.LastName);
        }

        [TestMethod]
        public void FirstLetterOfFirstNameStudentToUpperCheck()
        {
            //Arrange
            string firstNameInput = "richard";
            string firstNameOutputExpected = "Richard";

            //Act
            var testStudent = new Student(firstNameInput,"Rolle");

            //Assert
            Assert.AreEqual(firstNameOutputExpected,testStudent.FirstName);
        }

        [TestMethod]
        public void FirstLetterOfFirstNameWorkerToUpperCheck()
        {
            //Arrange
            string firstNameInput = "richard";
            string firstNameOutputExpected = "Richard";

            //Act
            var testWorker = new Worker(firstNameInput, "Rolle");

            //Assert
            Assert.AreEqual(firstNameOutputExpected, testWorker.FirstName);
        }
    }
}
