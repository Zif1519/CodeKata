namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution4 solution = new Solution4();
            Console.WriteLine(solution.solution(104));
            Console.WriteLine(solution.solution(4));
        }
    }

    public class Solution
    {
        public string solution(int num)
        {
            string answer = "";
            answer = (num % 2 == 0) ? "Even" : "Odd";
            return answer;
        }
    }

    public class Solution2
    {
        public double solution(int[] arr)
        {
            double answer = 0;
            foreach (double a in arr)
            {
                answer += a;
            }
            answer /= arr.Length;
            return answer;
        }
    }

    public class Solution3
    {
        public int solution(int n)
        {
            int answer = 0;
            while (n != 0)
            {
                answer += n % 10;
                n = n / 10;
            }
            return answer;
        }
    }

    public class Solution4
    {
        public int solution(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            { answer += (n % i == 0) ? i : 0 }
            return answer;
        }
    }

}