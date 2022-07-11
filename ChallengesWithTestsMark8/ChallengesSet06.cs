using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words == null) return false;
            if(word == null) return false;
            
            if (ignoreCase)
            {
                words = words.Where(x => x != null);
                words = words.Select(x => x.ToLower());
                word = word.ToLower();
            }
            
            Console.WriteLine(words.ToString(), ":"+word);
            if(words.Contains(word)) return true;
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num<2) return false;
            if(num==2) return true;
            for(int i = 2; i <=(int)Math.Ceiling( Math.Sqrt( num)); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null||str.Length==0) return -1;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                
                if (str.Where(x => x==str[i]).Count() == 1) return i;
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int lastNum = numbers[0];
            int count = 1;
            int maxCount = 0;
            for(int i=1;i<numbers.Length; i++)
            {
                if(numbers[i] ==lastNum)
                {
                    count++;
                }
                else
                {
                    maxCount=Math.Max(maxCount,count);
                    count = 1;
                    lastNum = numbers[i];
                }

            }

            return Math.Max(maxCount,count);
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if(elements==null||elements.Count==0||n==0) return new double[0];
            return elements.Where((x, i) => i % n == (n - 1)).ToArray();
        }
    }
}
