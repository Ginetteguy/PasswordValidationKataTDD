using NUnit.Framework;
using PasswordValidation;

namespace PasswordValidationTests
{
    public class PasswordValidatorTests
    {
        [Test]
        public void WhenPasswordLengthIs7_ShouldReturnThatIsTooShort()
        {
            // Arrange
            const string password = "ABCDEFG";
            
            // Setup
            string result = PasswordValidator.Validate(password);

            // Assert
            Assert.AreEqual("Password must be at least 8 characters", result);
        }
    }
}
