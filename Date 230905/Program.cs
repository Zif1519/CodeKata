namespace Date_230905
{

    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution soulution = new Solution();
            var result = soulution.solution(3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }


    public class Solution
    {
        public int[,] solution(int n)
        {
            
            List<List<int>> forAnswer = new List<List<int>>();
            forAnswer = TowerOfHanoi(1, 3, 2, n);
            int[,] answer = new int[forAnswer.Count,2];

            for ( int i=0; i < forAnswer.Count; i++)
            {
                answer[i,0] = forAnswer[i][0];
                answer[i,1] = forAnswer[i][1];
            }
            
            return answer;
        }

        public List<List<int>> TowerOfHanoi(int start, int end, int sub, int num)
        {
            List<List<int>> result = new List<List<int>>();
            if (num == 1)
            {
                List<int> temp = new List<int> { start, end };
                result.Add(temp);
            }
            else
            {
                result.AddRange(TowerOfHanoi(start, sub, end, num - 1));
                List<int> temp = new List<int> { start, end };
                result.Add(temp);
                result.AddRange(TowerOfHanoi(sub, end, start, num - 1));
            }
            return result;
        }
    }
}