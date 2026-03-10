using System.Text;

namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        private const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string Special = "!@#$%^&*()_+-=[]{}|;:,.<>?";

        private readonly Random _random = new();

        public string Generate(int length, bool useUppercase, bool useLowercase, bool useDigits, bool useSpecial)
        {
            if (length <= 0)
                throw new ArgumentException("Password length must be greater than 0");

            var charPool = new StringBuilder();
            var requiredChars = new List<char>();

            if (useUppercase)
            {
                charPool.Append(Uppercase);
                requiredChars.Add(Uppercase[_random.Next(Uppercase.Length)]);
            }
            if (useLowercase)
            {
                charPool.Append(Lowercase);
                requiredChars.Add(Lowercase[_random.Next(Lowercase.Length)]);
            }
            if (useDigits)
            {
                charPool.Append(Digits);
                requiredChars.Add(Digits[_random.Next(Digits.Length)]);
            }
            if (useSpecial)
            {
                charPool.Append(Special);
                requiredChars.Add(Special[_random.Next(Special.Length)]);
            }

            if (charPool.Length == 0)
                throw new ArgumentException("At least one character type must be selected");

            var pool = charPool.ToString();
            var password = new char[length];

            // Fill remaining positions with random characters from pool
            for (int i = 0; i < length; i++)
            {
                password[i] = pool[_random.Next(pool.Length)];
            }

            // Replace some positions with required characters to ensure at least one of each type
            var indices = Enumerable.Range(0, length).OrderBy(_ => _random.Next()).Take(requiredChars.Count).ToList();
            for (int i = 0; i < requiredChars.Count && i < indices.Count; i++)
            {
                password[indices[i]] = requiredChars[i];
            }

            return new string(password);
        }

        public static string GetRulesDescription(bool useUppercase, bool useLowercase, bool useDigits, bool useSpecial)
        {
            var rules = new List<string>();
            if (useUppercase) rules.Add("大写");
            if (useLowercase) rules.Add("小写");
            if (useDigits) rules.Add("数字");
            if (useSpecial) rules.Add("特殊");
            return string.Join("+", rules);
        }
    }
}
