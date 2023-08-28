using System.Security.Cryptography.X509Certificates;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution soulution = new Solution();
            var result = soulution.solution(273811);
            Console.WriteLine(result);
        }
    }

    public class Solution1
    {
        public int solution(string s)
        {
            int answer = 0;
            answer = int.Parse(s);
            return answer;
        }
    }

    public class Solution2
    {
        public long solution(long n)
        {
            long sqrt = (long)Math.Sqrt(n);
            if (sqrt * sqrt == n) return (sqrt + 1) * (sqrt + 1);
            else return -1;
        }
    }
    public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;
            char[] x = n.ToString().ToCharArray();
            Array.Sort(x);
            Array.Reverse(x);
            answer = long.Parse(new string(x));

            return answer;
        }
    }
}