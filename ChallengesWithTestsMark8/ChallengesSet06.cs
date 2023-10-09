using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;

            if (ignoreCase)
            {
                return words.Any(w => w != null && string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;
            if (num == 2 || num == 3) return true;
            if (num % 2 == 0 || num % 3 == 0) return false;

            int divisor = 5;
            while (divisor * divisor <= num)
            {
                if (num % divisor == 0 || num % (divisor + 2) == 0) return false;
                divisor += 6;  
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            {
                if (string.IsNullOrEmpty(str))
                {
                    return -1; 
                }

                Dictionary<char, int> letterIndex = new Dictionary<char, int>();
                HashSet<char> repeatedChars = new HashSet<char>();

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    char currentChar = str[i];

                    if (repeatedChars.Contains(currentChar))
                    {
                        continue;
                    }

                    if (!letterIndex.ContainsKey(currentChar))
                    {
                        letterIndex[currentChar] = i;
                    }

                    else
                    {
                        letterIndex.Remove(currentChar);
                        repeatedChars.Add(currentChar);
                    }
                }
                if (letterIndex.Count == 0)
                {
                    return -1;
                }
                int lastIndex = letterIndex.Values.Max();
                return lastIndex;
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; 
            }

            int maxCount = 1; 
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++; 
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount; 
                    }
                    currentCount = 1; 
                }
            }

            
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 1)
            {
                return new double[0]; 
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
