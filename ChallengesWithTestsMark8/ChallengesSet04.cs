using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null||numbers.Length == 0) return 0;
            return numbers.Select(x => x % 2 == 0 ? x : -x).ToList().Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return ReturnShorterString(ReturnShorterString(ReturnShorterString(str1, str2), str3), str4).Length;
        }
        //I added this method
        public string ReturnShorterString(string str1, string str2)
        {
            return (str1.Length<str2.Length)? str1 : str2;
        }
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2),number3),number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name ="TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            var longestSide = Math.Max(Math.Max(sideLength1, sideLength2), sideLength3);
            return (sideLength1 != 0 && sideLength2 != 0 && sideLength3 != 0)
                && (sideLength1 + sideLength2 + sideLength3 - longestSide > longestSide);
        }

        public bool IsStringANumber(string input)
        {
            return float.TryParse(input, out float number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x==null).ToArray().Length>objs.Length/2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            try { return numbers.Where(x => x % 2 == 0).Average();

            }catch (InvalidOperationException e) { return 0; }
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException();
            if (number ==0 || number == 1) return 1;
            return number * Factorial(number - 1);
        }
    }
}
