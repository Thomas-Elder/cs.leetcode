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
        public void StepsToChange_WhenGivenAStringString_Returns0()
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
    }
}
