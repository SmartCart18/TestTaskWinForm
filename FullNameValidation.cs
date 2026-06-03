using System;

namespace TestTaskWinForm
{
    internal class FullNameValidation // Валидация: 2-3 слова, каждое слово состоит только из букв, дефиса или апострофа
    {
        public static bool IsValid(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            var parts = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 2 || parts.Length > 3) return false;

            foreach (var part in parts)
            {
                foreach (char c in part)
                {
                    if (!(char.IsLetter(c) || c == '-' || c == '\''))
                        return false;
                }
            }

            return true;
        }
    }
}
