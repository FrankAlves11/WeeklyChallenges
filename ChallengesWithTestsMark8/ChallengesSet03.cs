using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool value in vals)
            {
                if (!value)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }


            foreach (int number in numbers)
            {
               if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }

                
                if (hasUpper && hasLower && hasNumber)
                {
                    break;
                }
            }

            return hasUpper && hasLower && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
            
                return ' ';
            }

           
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
              
                return ' ';
            }

            
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            
            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException("The array must contain at least two elements.");
            }

            
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int index = 0;

            for (int i = 1; i < 100; i += 2)
            {
                odds[index] = i;
                index++;
            }

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
            {
                return; 
            }

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i]?.ToUpper();
            }
        }
    }
}
