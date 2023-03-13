using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace Solutions.Tests.Medium
{
    [TestClass]
    public class SubrectangleQueriesTests
    {
        private SubrectangleQueries _subrectangleQueries;

        [TestMethod]
        public void GetValue_WhenCalled_ReturnsExpectedValue()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var expected = 2;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            var actual = _subrectangleQueries.GetValue(0, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetValue_WhenCalledAgain_ReturnsExpectedValue()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var expected = 3;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            var actual = _subrectangleQueries.GetValue(1, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateSubrectangle_WhenCalledToUpdateFirstCell_UpdatesAsExpected()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var newValue = 5;

            var expected = 5;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            _subrectangleQueries.UpdateSubrectangle(0, 0, 0, 0, 5);
            var actual = _subrectangleQueries.GetValue(0, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateSubrectangle_WhenCalledToUpdateLastCell_UpdatesAsExpected()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var newValue = 5;

            var expected = 5;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            _subrectangleQueries.UpdateSubrectangle(1, 1, 1, 1, 5);
            var actual = _subrectangleQueries.GetValue(1, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UpdateSubrectangle_WhenCalledToUpdateFirstColumn_UpdatesAsExpected()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var newValue = 5;

            var expected = 5;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            _subrectangleQueries.UpdateSubrectangle(0, 0, 1, 0, 5);
            var actualTop = _subrectangleQueries.GetValue(0, 0);
            var actualBottom = _subrectangleQueries.GetValue(1, 0);

            // Assert
            Assert.AreEqual(expected, actualTop);
            Assert.AreEqual(expected, actualBottom);
        }

        [TestMethod]
        public void UpdateSubrectangle_WhenCalledToUpdateLastColumn_UpdatesAsExpected()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var newValue = 5;

            var expected = 5;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            _subrectangleQueries.UpdateSubrectangle(0, 1, 1, 1, 5);
            var actualTop = _subrectangleQueries.GetValue(0, 1);
            var actualBottom = _subrectangleQueries.GetValue(1, 1);

            // Assert
            Assert.AreEqual(expected, actualTop);
            Assert.AreEqual(expected, actualBottom);
        }

        [TestMethod]
        public void UpdateSubrectangle_WhenCalledToUpdateFirstRow_UpdatesAsExpected()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var newValue = 5;

            var expected = 5;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            _subrectangleQueries.UpdateSubrectangle(0, 0, 0, 1, 5);
            var actualFirst = _subrectangleQueries.GetValue(0, 0);
            var actualLast = _subrectangleQueries.GetValue(0, 1);

            // Assert
            Assert.AreEqual(expected, actualFirst);
            Assert.AreEqual(expected, actualLast);
        }

        [TestMethod]
        public void UpdateSubrectangle_WhenCalledToUpdateLastRow_UpdatesAsExpected()
        {
            // Arrange
            var input = new int[2][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3, 4 };

            var newValue = 5;

            var expected = 5;

            _subrectangleQueries = new SubrectangleQueries(input);

            // Act
            _subrectangleQueries.UpdateSubrectangle(1, 0, 1, 1, 5);
            var actualFirst = _subrectangleQueries.GetValue(1, 0);
            var actualLast = _subrectangleQueries.GetValue(1, 1);

            // Assert
            Assert.AreEqual(expected, actualFirst);
            Assert.AreEqual(expected, actualLast);
        }
    }
}
