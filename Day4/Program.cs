namespace Day4
{
    using Linq;
    using System.Collections;
    using System.Collections.Immutable;

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution soulution = new Solution();
            var result = soulution.solution(13, 17);
            Console.WriteLine(result);
        }
    }

    public class Solution1
    {
        public bool solution(int x)
        {
            bool answer = true;
            int a = 0;
            int b = x;
            while (b >= 1)
            {
                a += b % 10;
                b = b / 10;
            }
            if (x % a != 0) { answer = false; }
            return answer;
        }
    }

    public class Solution2
    {
        public int solution(int num)
        {

            int count = 0;
            long temp = (long)num;
            while (count < 500)
            {
                if (temp == 1) break;
                count++;
                if (temp % 2 == 0)
                {
                    temp /= 2;
                }
                else
                {
                    temp = temp * 3 + 1;
                }
            }
            if (count == 500) return -1;
            return count;
        }
    }
    public class Solution3
    {
        public string solution(string[] seoul)
        {

            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                {
                    return $"김서방은 {i}에 있다";
                }
            }
            return "김서방 없다.";
        }
    }
    public class Solution4
    {
        public int[] solution(int[] arr, int divisor)
        {
            int[] answer = new int[] { };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0)
                {
                    answer[count] = arr[i];
                    count++;
                }
            }
            if (count == 0) answer[count] = -1;
            return answer;
        }
    }
    public class Solution5
    {
        public int[] solution(int[] arr, int divisor)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0) { temp.Add(arr[i]); }
            }
            temp.Sort();
            if (temp.Count == 0) return new int[] { -1 };
            int[] answer = new int[temp.Count];

            for (int i = 0; i < temp.Count; i++)
            {
                answer[i] = temp[i];
            }

            return answer;
        }
    }


    public class Solution6
    {
        public int solution(int[] absolutes, bool[] signs)
        {
            int answer = 0;
            for (int i = 0; i < signs.Length; i++)
            {
                answer += signs[i] ? absolutes[i] : -absolutes[i];
            }
            return answer;
        }
    }

    public class Solution7
    {
        public string solution(string phone_number)
        {
            int length = phone_number.Length;
            string answer = "";
            for (int i = 0; i < length; i++)
            {

                answer += (i >= length - 4) ? phone_number[i] : '*';
            }
            return answer;
        }
    }


    public class Solution8
    {
        public int solution(int[] numbers)
        {
            int answer = 45;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer -= numbers[i];
            }
            return answer;
        }
    }
    public class Solution9
    {
        public int[] solution(int[] arr)
        {
            if (arr.Length == 1) return new int[] { -1 };
            int[] answer = new int[arr.Length - 1];
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    index = i;
                    min = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < index) { answer[i] = arr[i]; }
                if (i > index) { answer[i - 1] = arr[i]; }
            }
            return answer;
        }
    }
    public class Solution10
    {
        public string solution(int n)
        {
            string answer = "";
            bool isOdd = true;
            while (n > 0)
            {
                n--;
                answer += isOdd ? '수' : '박';
                isOdd = !isOdd;
            }
            return answer;
        }
    }

    public class Solution11
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            for (int i = left; i < right + 1; i++)
            {
                var sqrt = Math.Sqrt(i);
                if (i == (int)sqrt * (int)sqrt) { answer -= i; }
                else { answer += i; }
            }
            return answer;
        }
    }

    public class Solution12
    {
        public string solution(string s)
        {
            char[] temp = s.ToCharArray();
            temp = temp.OrderBy(c => c).ToArray();
            temp = temp.Reverse().ToArray();
            return new string(temp);
        }
    }

    public class Example
    {
        public static void Main()
        {
            String[] s;
            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }



    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;
            List<int> num3 = new List<int>();
            while (n != 0)
            {
                num3.Add(n % 3);
                n = n / 3;
            }
            for (int i = 0; i < num3.Count; i++)
            {
                answer = answer * 3 + num3[i];
            }
            return answer;
        }
    }



}