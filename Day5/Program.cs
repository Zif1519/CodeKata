namespace Day5
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution soulution = new Solution();
            var result = soulution.solution("hili");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string solution(string s)
        {
            string answer = "";
            string[] splitedS;
            if (s.IndexOf(' ') != -1)
            {
                splitedS = s.Split(' ');
            }
            else
            {
                splitedS = new string[] { s };
            }
            for (int i = 0; i < splitedS.Length; i++)
            {
                char[] charArray = splitedS[i].ToCharArray();
                for (int j = 0; j < splitedS[i].Length; j++)
                {
                    charArray[j] = j % 2 == 0 ? char.ToUpper(charArray[j]) : char.ToLower(charArray[j]);
                }
                splitedS[i] = new string(charArray);
                answer += splitedS[i];
                answer += i != (splitedS.Length - 1) ? " " : "";
            }
            return answer;
        }


        public class Solution2
        {
            public int solution(string t, string p)
            {
                int answer = 0;
                int b = int.Parse(p);
                for (int i = 0; i < t.Length - p.Length + 1; i++)
                {
                    int a = int.Parse(t.Substring(i, p.Length));
                    if (a <= b) answer += 1;
                }
                return answer;
            }
        }
    }

    using System;

public class Solution
    {
        public int solution(string t, string p)
        {
            int answer = 0;
            int tLength = t.Length;
            int pLength = p.Length;
            int b = int.Parse(p);
            int a;
            for (int i = 0; i < tLength - pLength + 1; i++)
            {
                a = int.Parse(t.Substring(i, p.Length));
                if (a <= b) answer += 1;
            }
            return answer;
        }
    }

}