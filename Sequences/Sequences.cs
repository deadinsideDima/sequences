using System;

namespace Sequences
{
    public static class Sequences
    {
        /// <summary>
        /// Find all the contiguous substrings of "length" length in given string of digits in the order that they appear.
        /// </summary>
        /// <param name="numbers">Source string.</param>
        /// <param name="length">Length of substring.</param>
        /// <returns>All the contiguous substrings of length n in that string in the order that they appear.</returns>
        /// <exception cref="ArgumentException">
        /// Throw if length of substring less and equals zero
        /// -or-
        /// more than length of source string
        /// - or-
        /// source string containing a non-digit character
        /// - or
        /// source string is null or empty or white space.
        /// </exception>
        public static string[] GetSubstrings(string numbers, int length)
        {
            if (string.IsNullOrEmpty(numbers) || string.IsNullOrWhiteSpace(numbers))
            {
                throw new ArgumentException("Source string is null or empty or white space.");
            }

            if (length <= 0)
            {
                throw new ArgumentException("Length of substring less or equals zero.");
            }

            if (length > numbers.Length)
            {
                throw new ArgumentException("Length more than length of source string.");
            }

            List<string> array = new List<string>();
            for (int i = 0; i <= numbers.Length - length; i++)
            {
                string temp = string.Empty;
                for (int j = i; j < length + i; j++)
                {
                    if (numbers[j] != '0' && numbers[j] != '1' && numbers[j] != '2' && numbers[j] != '3' && numbers[j] != '4' && numbers[j] != '5' && numbers[j] != '6' && numbers[j] != '7' && numbers[j] != '8' && numbers[j] != '9')
                    {
                        throw new ArgumentException("Source string containing a non-digit character.");
                    }

                    temp = string.Empty + temp + numbers[j];
                }

                array.Add(temp);
            }

            return array.ToArray();
        }
    }
}
