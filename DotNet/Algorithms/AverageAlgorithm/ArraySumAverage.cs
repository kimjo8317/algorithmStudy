//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;
////TODO 2차원 배열을 사용하여(3행 4열), 합계와 평균 구하기
//namespace DotNet.Algorithms.AverageAlgorithm
//{
//    internal class ArraySumAverage
//    {
//        static void Main(string[] args)
//        {

//        int[,] scores = 
//        { 
//            {90, 100, 0, 0},
//            {80, 90, 0, 0},
//            {100, 80, 0, 0} 
//        };
//            for (int i = 0; i < 3; i++)
//            {
//                scores[i, 2] = scores[i, 0] + scores[i, 1];//sum 
//                scores[i, 3] = scores[i, 2] / 2;//avg 
//            }
//            Console.WriteLine("테이블1열 , 테이블2열 합계 평균");
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    Console.Write($"{scores[i, j], 8}");//8은 띄워쓰기 칸
//                }
//                Console.WriteLine();
//            }
//        }
//}
//}