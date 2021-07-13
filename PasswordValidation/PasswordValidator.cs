using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        private List<string> passwordValidationErrors = new List<string>();

        public string Validate(string password)
        {
            ValidatePasswordLength(password);

            ValidatePasswordContainsAtLeastTwoNumbers(password);

            ValidatePasswordContainsAtLeastOneCapitalLetter(password);

            ValidatePasswordContainsAtLeastOneSpecialCaracter(password);

            return FormatPasswordValidationErrors();
        }

        private void ValidatePasswordLength(string password)
        {
            if (!new Regex(@".{8,}").IsMatch(password))
                passwordValidationErrors.Add("Password must be at least 8 characters");
        }

        private void ValidatePasswordContainsAtLeastTwoNumbers(string password)
        {
            if (!new Regex(@"[0-9]{2,}").IsMatch(password))
                passwordValidationErrors.Add("The password must contain at least 2 numbers");
        }

        private void ValidatePasswordContainsAtLeastOneCapitalLetter(string password)
        {
            if (!new Regex(@"[A-Z]+").IsMatch(password))
                passwordValidationErrors.Add("Password must contain at least one capital letter");
        }

        private void ValidatePasswordContainsAtLeastOneSpecialCaracter(string password)
        {
            if (!new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]").IsMatch(password))
                passwordValidationErrors.Add("Password must contain at least one special character");
        }

        private string FormatPasswordValidationErrors()
        {
            return string.Join("\n", passwordValidationErrors);
        }
    }
}
