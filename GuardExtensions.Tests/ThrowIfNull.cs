using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuardExtensions.Tests
{
    [TestClass]
    public class ThrowIfNull
    {
        [TestMethod]
        public void WhenParameterIsNotNull_ReturnsSameParameterObject()
        {
            // Arrange
            var testObject = new {};

            // Act
            var result = testObject.ThrowIfNull(nameof(testObject));

            // Assert
            Assert.AreSame(testObject, result);
        }

        [TestMethod]
        public void WhenParameterIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            object testObject = null;

            // Act
            // Assert
            var ex = Assert.ThrowsException<ArgumentNullException>(() => testObject.ThrowIfNull(nameof(testObject)));
            Assert.AreEqual(nameof(testObject), ex.ParamName);
        }
    }
}
