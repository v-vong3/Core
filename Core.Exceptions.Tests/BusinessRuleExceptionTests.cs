using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Core.Exceptions.Tests
{
    [TestCategory("Regression")]
    [TestClass]
    public class BusinessRuleExceptionTests
    {
        [TestMethod]
        public void BRException_CtorWithInnerException_Pass()
        {
            // Arrange
            var message = nameof(BusinessRuleException);
            var placeholderMessage = $"Violation of business rule. {message}";
            var innerMessage = message + message;

            // Act
            var bre = new BusinessRuleException(message, new Exception(innerMessage));

            // Assert
            Assert.IsNotNull(bre);
            Assert.AreEqual(placeholderMessage, bre.Message);
            Assert.IsNotNull(bre.InnerException);
            Assert.AreEqual(innerMessage, bre.InnerException.Message);

        }



    }
}
