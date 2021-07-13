using System;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        public static string Validate(string password)
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters";

            return string.Empty;
        }
    }
}
