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
            const string firstNameInput = "benjamin";
            const string firstNameOutputExpected = "Benjamin";

            //Act
            var testMensch = new Human(firstNameInput, "Becher");

            //Assert
            Assert.AreEqual(firstNameOutputExpected, testMensch.FirstName);
        }

        [TestMethod]
        public void FirstLetterOfLastNameToUpperCaseCheck()
        {
            //Arrange
            const string lastNameInput = "becher";
            const string lastNameOutputExpected = "Becher";

            //Act
            var testMensch = new Human("Benjamin", lastNameInput);

            //Assert
            Assert.AreEqual(lastNameOutputExpected, testMensch.LastName);
        }

        [TestMethod]
        public void FirstLetterOfFirstNameStudentToUpperCheck()
        {
            //Arrange
            const string firstNameInput = "richard";
            const string firstNameOutputExpected = "Richard";

            //Act
            var testStudent = new Student(firstNameInput, "Rolle", 1);

            //Assert
            Assert.AreEqual(firstNameOutputExpected, testStudent.FirstName);
        }

        [TestMethod]
        public void FirstLetterOfFirstNameWorkerToUpperCheck()
        {
            //Arrange
            const string firstNameInput = "richard";
            const string firstNameOutputExpected = "Richard";

            //Act
            var testWorker = new Worker(firstNameInput, "Rolle", 8, 8);

            //Assert
            Assert.AreEqual(firstNameOutputExpected, testWorker.FirstName);
        }

        [TestMethod]
        public void LatterLettersOfFirstNameWorkerToLowerCheck()
        {
            //Arrange
            const string firstNameInput = "RiChArd";
            const string firstNameOutputExpected = "Richard";

            //Act
            var testWorker = new Worker(firstNameInput, "Rolle", 8, 8);

            //Assert
            Assert.AreEqual(firstNameOutputExpected, testWorker.FirstName);
        }
    }
}
