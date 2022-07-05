using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return startNumber / n * n + n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i=0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue <=0)
                    businesses[i].Name="CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers==null||numbers.Length==0) return false;
            if (numbers.Length <= 1) return true;
            for(int i=1; i < numbers.Length; i++)
                if (numbers[i] < numbers[i - 1]) return false;
            return true;
           
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers==null) return 0;
            int i;
            int sum = 0;
            for(i=0;i<numbers.Length;i++)
            {
                if (numbers[i]%2==0&&i+1<numbers.Length)
                        sum+=numbers[i+1];   
                
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";
            string s = "";
            string[] array = (new List<string>(words)).Select((x, i) => (i == words.Length - 1) ? x.Trim() + "." : x.Trim() + " ").ToArray();
            foreach(string word in array)
            {
                if(word!=" "&&word!=".") s+=word;
            }
                
              return s;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements==null || elements.Count == 0) return new double[]{ };
            return elements.Where((x,i)=>i%4==3).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (i!=j&&nums[i]+nums[j]==targetNumber) return true;
                }
            }
            return false;
        }
    }
}
