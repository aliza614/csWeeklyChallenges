using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) return true;
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {   if (vals == null) return false;
            int count = 0;
            foreach (string val in vals)
                count++;
            return (count % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return number%2==0;
        }

        public bool IsNumberOdd(int num)
        {
            return num%2!=0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null||numbers.Count()==0) return 0;
            var min = numbers.First();
            var max = numbers.First();
            foreach (var number in numbers)
            {
                min=Math.Min(min, number);
                max=Math.Max(max, number);
            }
            return (min+max);
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null) return 0;
            var sum = 0;
            foreach(var number in numbers)
            {
                if (number % 2 == 0) sum += number;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 !=0) sum += number;
            }
            return sum%2!=0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            for (long i = 1; i < number; i += 2)
                count++;
            return count;
        }
    }
}
