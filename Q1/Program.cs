namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(3));
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


}