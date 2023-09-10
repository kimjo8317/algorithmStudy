using System;


class SumAlgorithm
{
    static void Main()
    {
        //[1] Input = ex) 데이터구조, 자료구조 영역
        //[2] Process = 알고리즘 영역
        //[3] Output = ex) C#콘솔 ,윈도우폼, 웹폼 등등

        //문제1 n명의 영어중에서 80점이상인 점수의 합계 구하기 
        int[] scores = { 100, 75, 50, 37, 90, 95 };
        int sum = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] >= 80)
            {
                sum += scores[i];
            }
        }

        Console.WriteLine($"{scores.Length}명의 점수중 80점 이상의 총점(합계):{sum}");
    }
}
