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
            const string password = "@BCDE12";
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
            const string password = "@BCDEFGH";
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
            const string password = "@BCDEF1";
            PasswordValidator passwordValidator = new PasswordValidator();

            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual("Password must be at least 8 characters\nThe password must contain at least 2 numbers", result);
        }

        [Test]
        public void WhenPasswordDoesntContainsOneLetterCapitalAtLeast_ShouldReturnError()
        {
            // Arrange
            const string password = "@bcdef12";
            PasswordValidator passwordValidator = new PasswordValidator();

            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual("Password must contain at least one capital letter", result);
        }

        [Test]
        public void WhenPasswordDoesntContainsOneSpecialCaracterAtLeast_ShouldReturnError()
        {
            // Arrange
            const string password = "Abcdef12";
            PasswordValidator passwordValidator = new PasswordValidator();

            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual("Password must contain at least one special character", result);
        }

        [Test]
        public void WhenPasswordIsEmpty_ShouldReturnAllErrors()
        {
            // Arrange
            const string password = "";
            PasswordValidator passwordValidator = new PasswordValidator();
            const string expected = "Password must be at least 8 characters\n" +
                "The password must contain at least 2 numbers\n" +
                "Password must contain at least one capital letter\n" +
                "Password must contain at least one special character";

            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void WhenPasswordIsValid_ShouldReturnNoError()
        {
            // Arrange
            const string password = "@BCDEF12";
            PasswordValidator passwordValidator = new PasswordValidator();

            // Setup
            string result = passwordValidator.Validate(password);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}
