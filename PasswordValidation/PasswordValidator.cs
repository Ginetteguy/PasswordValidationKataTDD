using System;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        public static string Validate(string password)
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters";

            int numberCounter = 0;
            Array.ForEach(password.ToCharArray(), delegate (char character) { if (Char.IsNumber(character)) { numberCounter++; } });

            if (numberCounter < 2)
                return "The password must contain at least 2 numbers";

            return string.Empty;
        }
    }
}
