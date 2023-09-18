//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////TODO 5명의 학생의 점수를 입력받아서 전체 인원의 평균 이상의 성적인 학생의 수를 구하기
////평균이상의 인원 수 구하기

////평균 이상의 인원 : 평균(합계,개수) -> 개수
//namespace DotNet.Algorithms.AverageAlgorithm
//{
//    internal class AverageCount
//    {
//        static void Main()
//        {
//            //input
//            int[] scores = { 100, 90, 80, 70, 60, 50, 40 };
//            var sum = 0;//총점
//            var count = 0;//개수
//            var avg = 0.0;//평균
//            var resultCount = 0;//평균 이상 인원수

//            //process //sum , count , average  -> count
//            for (int i = 0; i < scores.Length; i++)
//            {
//                sum += scores[i];//sum
//                count++;//count
//            }
//            if (sum != 0 && count != 0)
//            {
//                avg = sum / (double)count;//average
//            }
//            //process2 //average Over Count 평균 이상 인원 수
//            for (int i = 0;i < scores.Length; i++) 
//            {
//                if (scores[i] >= avg)//평균이상의 인원수 구하기
//                {
//                    resultCount++; //또 다른 COUNT 알고리즘   
//                }
//            }
//            //output
//            Console.WriteLine($"평균({avg}점) 이상의 점수를 받은 학생수 : {resultCount}명 이다");
//        }

//    }
//}
