using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers!=null &&numbers.Count()!=0&&numbers.Where(x => x % 2 !=0).Sum()%2!=0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            bool ans = password.ToUpper() != password && password.ToLower() != password;
            foreach (var c in password)
            {
                if (char.IsDigit(c) && c != '.')
                    return ans;
            }
            return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return (decimal)dividend/ divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums.Length==0||nums==null) return 0;
            return nums.Last()-nums.First();
        }

        public int[] GetOddsBelow100()
        {
            List<int> l = new List<int>();
            for(int i=1;i<100;i+=2)
                l.Add(i);
            return l.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
