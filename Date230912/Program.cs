namespace Date230912
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution soulution = new Solution();

            var insert = new string[3] { "sun", "bed", "car" };
            var result = soulution.solution(insert, 1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    public class Solution2
    {
        public int solution2(string s)
        {
            int answer = 0;
            s = s.Replace("zero", "0").Replace("one", "1").Replace("two", "2")
                .Replace("three", "3").Replace("four", "4").Replace("five", "5")
                .Replace("six", "6").Replace("seven", "7").Replace("eight", "8")
                .Replace("nine", "9");
            int.TryParse(s, out answer);
            return answer;
        }
    }

    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[] { };
            answer = strings.OrderBy(str => str[n])
                .ThenBy(str => str).ToArray();
            return answer;
        }
    }

}