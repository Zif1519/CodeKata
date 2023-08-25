namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution6 solution = new Solution6();
            var a = solution.solution(2,5);
            Console.WriteLine(a[0]);
        }
    }

public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            answer = 2;
            while (n % answer != 1)
            {
                answer++;
            }
            return answer;
        }
    }

    public class Solution6
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            for (int i = 0; i < n; i++)
            {
                answer[i] = (long) (i + 1) * x;
            }
            return answer;
        }
    }

    public class Solution7
    {
        public int[] solution(long n)
        {
            int[] answer = new int[n];
            int i = 0;
            while (i < n)
            {
                answer[i] = n - i;
                i++;
            }
            return answer;
        }
    }


public class Solution8
    {
        public int[] solution(long n)
        {
            string nString = new string(n.ToString().ToCharArray().Reverse().ToArray());
            int[] answer = new int[nString.Length];

            for (int i = 0; i < nString.Length; i++)
            {
                answer[i] = int.Parse(nString[i].ToString());
            }

            return answer;
        }
    }
}
