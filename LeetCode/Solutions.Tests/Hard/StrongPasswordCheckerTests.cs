using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Hard;

namespace Solutions.Tests.Hard
{
    [TestClass]
    public class StrongPasswordCheckerTests
    {

        [TestMethod]
        public void StepsToChange_WhenGivenSingleCharacterString_Returns5()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 5;
            string password = "a";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepsToChange_WhenGiven3CharacterString_Returns3()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 3;
            string password = "aA1";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepsToChange_WhenGivenAStrongPasswordString_Returns0()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 0;
            string password = "1337C0d3";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepsToChange_WhenGivenAShortButStrongString_Returns1()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 1;
            string password = "aA123";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void StepsToChange_WhenGivenACorrectLengthString_Returns1()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 1;
            string password = "aaa123";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void StepsToChange_WhenGivenAnotherCorrectLengthString_Returns1()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 2;
            string password = "aaa111";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void StepsToChange_WhenGivenRepeatedCharactersString_Returns3()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 3;
            string password = "1111111111";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepsToChange_WhenGivenPasswordTooLong_Returns2()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 2;
            string password = "ABABABABABABABABABAB1";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepsToChange_WhenGivenPasswordTooLong_Returns8()
        {
            // Arrange
            StrongPasswordChecker strongPasswordChecker = new StrongPasswordChecker();
            int expected = 8;
            string password = "bbaaaaaaaaaaaaaaacccccc";

            // Act 
            int actual = strongPasswordChecker.StepsToChange(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
