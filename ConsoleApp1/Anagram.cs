using System.Text;

namespace ConsoleApp1
{
    public class Anagram
    {
        private static string ReverseWord(string? str)
        {
            string result = "";
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            var symbolsDictionary = FindNonLetters(str);
            StringBuilder sb = new();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (Char.IsLetter(str[i]))
                {
                    result += str[i];
                }
            }

            sb.Append(result);

            foreach (var row in symbolsDictionary)
            {
                sb.Insert(row.Key, row.Value);
            }

            return sb.ToString();
        }

        public static string Reverse(string? str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (!str.Contains(' '))
            {
                return ReverseWord(str);
            }

            var symbolsDictionary = FindNonLetters(str);
            StringBuilder sb = new();

            string result = "";

            string[] splitedstr = str.Split(' ');

            foreach (var word in splitedstr)
            {
                string tempString = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    if (Char.IsLetter(word[i]))
                    {
                        tempString += word[i];
                    }
                }
                result += tempString;
                tempString = string.Empty;
            }

            sb.Append(result);

            foreach (var row in symbolsDictionary)
            {
                sb.Insert(row.Key, row.Value);
            }

            return sb.ToString();
        }

        private static Dictionary<int, char> FindNonLetters(string str)
        {
            var indexesDictionary = new Dictionary<int, char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(str[i]))
                {
                    indexesDictionary.Add(i, str[i]);
                }
            }
            return indexesDictionary;
        }
    }
}
