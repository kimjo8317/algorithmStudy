//n명의 점수중에서 80점 이상 95점 이하인 점수의 평균
//주어진 범위에 주어진 조건에 해당하는 자료들의 평균
using System;
using System.Linq;

namespace DotNet.Algorithms.AverageAlgorithm
{
    internal class AverageAlgorithm
    {
        static void Main(string[] args)
        {
            //input: n명의 성적
            int[] data = { 90, 65, 78, 50, 95 };
            int sum = 0;//합계를 담을곳
            int count = 0;//개수를 담을곳

            //process: 처리 : AVG = SUM / COUNT
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 80 && data[i] <= 95)
                {
                    sum += data[i]; //SUM
                    count++; //COUNT
                }
            }
            double avg = sum / (double)count;//AVERAGE

            //output
            Console.WriteLine($"80점 이상 95점 이하인 자료의 평균: {avg}");//92.5
        }
    }
}
