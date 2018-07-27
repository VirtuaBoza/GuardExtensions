using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuardExtensions.Tests
{
    [TestClass]
    public class ThrowIfNullOrWhiteSpace
    {
        [TestMethod]
        public void WhenStringIsNotEmpty_ReturnsSameParameterObject()
        {
            // Arrange
            var testObject = "Not empty";

            // Act
            var result = testObject.ThrowIfNullOrWhiteSpace(nameof(testObject));

            // Assert
            Assert.AreSame(testObject, result);
        }

        [TestMethod]
        public void WhenStringIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            string testObject = null;

            // Act
            // Assert
            var ex = Assert.ThrowsException<ArgumentNullException>(() => testObject.ThrowIfNullOrWhiteSpace(nameof(testObject)));
            Assert.AreEqual(nameof(testObject), ex.ParamName);
        }

        [TestMethod]
        public void WhenStringIsEmpty_ThrowsArgumentException()
        {
            // Arrange
            var testObject = "";

            // Act
            // Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => testObject.ThrowIfNullOrWhiteSpace(nameof(testObject)));
            Assert.AreEqual(nameof(testObject), ex.ParamName);
        }

        [TestMethod]
        public void WhenStringIsWhiteSpace_ThrowsArgumentException()
        {
            // Arrange
            var testObject = " \f\n\r\t\v\x85";

            // Act
            // Assert
            var ex = Assert.ThrowsException<ArgumentException>(() => testObject.ThrowIfNullOrWhiteSpace(nameof(testObject)));
            Assert.AreEqual(nameof(testObject), ex.ParamName);
        }
    }
}
