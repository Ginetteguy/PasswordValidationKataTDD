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

        [Test]
        public void WhenPasswordDoesntContains2NumbersAtLeast_ShouldReturnError()
        {
            // Arrange
            const string password = "ABCDEFGH";

            // Setup
            string result = PasswordValidator.Validate(password);

            // Assert
            Assert.AreEqual("The password must contain at least 2 numbers", result);
        }
    }
}
