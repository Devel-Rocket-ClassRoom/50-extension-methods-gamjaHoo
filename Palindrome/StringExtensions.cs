using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            int left = 0;
            int right = text.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(text[left]))
                    left++;

                while (left < right && !char.IsLetterOrDigit(text[right]))
                    right--;

                if (char.ToLower(text[left]) != char.ToLower(text[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
