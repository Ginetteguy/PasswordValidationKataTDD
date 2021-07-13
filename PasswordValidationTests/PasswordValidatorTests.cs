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
            const string password = "ABCDE12";
            PasswordValidator passwordValidator = new PasswordValidator();
            
            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual("Password must be at least 8 characters", result);
        }

        [Test]
        public void WhenPasswordDoesntContains2NumbersAtLeast_ShouldReturnError()
        {
            // Arrange
            const string password = "ABCDEFGH";
            PasswordValidator passwordValidator = new PasswordValidator();

            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual("The password must contain at least 2 numbers", result);
        }

        [Test]
        public void WhenPasswordLengthIsLessThan8AndDoesntContains2NumbersAtLeast_ShouldReturnTwoErrors()
        {
            // Arrange
            const string password = "ABCDEF1";
            PasswordValidator passwordValidator = new PasswordValidator();

            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual("Password must be at least 8 characters\nThe password must contain at least 2 numbers", result);
        }
    }
}
