using System;
using System.Text.RegularExpressions;

namespace UserinyerfaceTests.CustomUtilities
{
    public static class StringExtensionMethods
    {
        private const string matchAnyExceptDigitsReg = @"[^\d]";

        public static string RemoveStartingSubstring(this string str, string startingSubstr) => str.Remove(0, startingSubstr.Length).Trim();

        public static int? GetNumberFromText(this string str)
        {
            int number;
            string Text = Regex.Replace(str, matchAnyExceptDigitsReg, "");
            bool success = int.TryParse(Text, out number);
            return success ? number : (int?)null;
        }

        public static string GetTextBeforeCharacter(this string str, char chr)
        {
            if (!String.IsNullOrWhiteSpace(str))
            {
                int charIndex = str.IndexOf(chr);

                if (charIndex > 0)
                {
                    return str.Substring(0, charIndex);
                }
            }
            return String.Empty;
        }

        public static string GetTextBetweenCharacters(this string strInput, char firstCharInput, char secondCharInput)
        {
            int numberIfIndexOfCharIsNotFound = -1;
            int firstCharIndex = strInput.IndexOf(firstCharInput);
            int afterFirstCharIndex = firstCharIndex + 1;
            if (firstCharIndex != numberIfIndexOfCharIsNotFound) 
            {
                int secondCharIndex = strInput.IndexOf(secondCharInput, afterFirstCharIndex);
                if (secondCharIndex != numberIfIndexOfCharIsNotFound) 
                {
                    int resultSubstringLength = secondCharIndex - firstCharIndex - 1;
                    return strInput.Substring(afterFirstCharIndex, resultSubstringLength);
                }
            }
            return string.Empty;
        }
    }
}
