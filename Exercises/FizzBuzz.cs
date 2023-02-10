using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Exercises
{
    //412. Fizz Buzz
    public static class FizzBuzz
    {
        public static IList<string> FizzBuzzMethod(int n) 
        { 
            List<string> answer = new List<string>();
            for(int i = 0; i < n + 1; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    answer.Add("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    answer.Add("Fizz");
                }
                else if(i % 5 == 0)
                {
                    answer.Add("Buzz");
                }
                else 
                {
                    answer.Add(i.ToString());
                }
            }
            return answer;
        }
    }
}
