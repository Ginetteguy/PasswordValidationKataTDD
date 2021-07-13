using System;
using System.Collections.Generic;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        private List<string> passwordValidationErrors = new List<string>();

        public string Validate(string password)
        {
            ValidatePasswordLength(password);

            ValidatePasswordContainsAtLeastTwoNumbers(password);

            return FormatPasswordValidationErrors();
        }

        private void ValidatePasswordLength(string password)
        {
            if (password.Length < 8)
                passwordValidationErrors.Add("Password must be at least 8 characters");
        }

        private void ValidatePasswordContainsAtLeastTwoNumbers(string password)
        {
            int numberCounter = 0;
            Array.ForEach(password.ToCharArray(), delegate (char character) { if (Char.IsNumber(character)) { numberCounter++; } });

            if (numberCounter < 2)
                passwordValidationErrors.Add("The password must contain at least 2 numbers");
        }

        private string FormatPasswordValidationErrors()
        {
            return string.Join("\n", passwordValidationErrors);
        }
    }
}
