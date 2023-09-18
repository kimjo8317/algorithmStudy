using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO 주어진 데이터 중에서 가장 큰 값 구하기
//최댓값 알고리즘(Max Algorithm): (주어진 범위 + 주어진 조건)의 데이터들의 가장 큰 값
namespace DotNet.Algorithms.MaxAlgorithm
{
    internal class MaxAlgorithm
    {
        static void Main() //명령줄 인수 제거
        {
            //Initialzie 초기화
            var max = int.MinValue; //정수 형식의 데이터 중 가장 작은 값으로 초기화(MinValue)
            

            //Input
            int[] numbers = { -2, -5, -3, -7, -1 };
            //Process: MAX
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];//max: 더큰 값으로 할당시킴
                }
            }

            //Output
            Console.WriteLine($"최댓값(식):{numbers.Max()}");//확장(extension)메서드 //식이 빠름
            Console.WriteLine($"최댓값(문):{max}");
        }
    }
}
