using System.Linq;
using System.Text;

namespace RD3LanguageInterpreter
{
    public static class StringExtensions
    {
        public static string TrimFull(this string text)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                switch (c)
                {
                    case '\r':
                    case '\n':
                    case '\t':
                    case ' ':
                        continue;
                    default:
                        sb.Append(c);
                        break;
                }
            }
            return sb.ToString();
        }

        public static bool IsNumber(this string text)
        {
            return text.ToCharArray().All(char.IsDigit);
        }
    }
}