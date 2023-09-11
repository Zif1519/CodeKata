namespace Day7
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] insert = new int[,] { { 14, 4 }, { 19, 6 }, { 6, 16 }, { 18, 7 }, { 7, 11 } };
            string insert = "a B c";
            Solution soulution = new Solution();
            var result = soulution.solution(insert,4);
            Console.WriteLine(result);
        }
    }


    public class Solution2
    {
        public int solution2(int[,] sizes)
        {
            int answer = 0;
            int maxW = 0;
            int maxH = 0;
            for (int i = 0; i < sizes.Length; i++)
            {
                if (sizes[i, 0] > sizes[i, 1])
                {
                    if (maxW < sizes[i, 0]) maxW = sizes[i, 0];
                    if (maxH < sizes[i, 1]) maxH = sizes[i, 1];
                }
                else
                {
                    if (maxH < sizes[i, 0]) maxH = sizes[i, 0];
                    if (maxW < sizes[i, 1]) maxW = sizes[i, 1];
                }
            }

            answer = maxW * maxH;
            return answer;
        }
    }
    public class Solution
    {
        public string solution(string s, int n)
        {
            string answer = "";
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] <= 'z'&& chars[i] >= 'a')
                {
                    chars[i] = (char)((chars[i] + n));
                    if (chars[i] > 'z') chars[i] = (char)(chars[i] - 26);
                }
                if (chars[i] <= 'Z' && chars[i] >= 'A')
                {
                    chars[i] = (char)((chars[i] + n));
                    if (chars[i] > 'Z') chars[i] = (char)(chars[i] - 26);
                }
            }
            // a 는 97,  소문자는 26개  A 는 65 ,
            answer = new string(chars);
            Console.WriteLine(answer);
            Console.ReadLine();
            return answer;
        }
    }
}