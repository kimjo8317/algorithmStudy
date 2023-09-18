//using System;
////summary Algorithm : 주어진 범위에 조건에 해당하는 자료들의 합계
//class SumAlgorithm
//{
//    static void Main()
//    {
//        //알고리즘이란? 
//        //프로그램 개발에 있어서 필요한 문제를 해결하는 방법을 체계적으로 정리하는방법
//        //문제해결능력
//        //프로그램의 작은 단위, 입력(Input) -> 처리(Process)->출력(Output) 의 단계에서 처리의 단계가 알고리즘

//        //[1] Input = ex) 데이터구조, 자료구조 영역
//        //[2] Process = 알고리즘 영역
//        //[3] Output = ex) C#콘솔 ,윈도우폼, 웹폼 등등

//        //문제1 n명의 영어중에서 80점이상인 점수의 합계 구하기 
//        int[] scores = { 100, 75, 50, 37, 90, 95, 80, 80, 81, 85, 89, 20, 33, 100, 99, 70 };
//        int sum = 0;

//        for (int i = 0; i < scores.Length; i++)
//        {
//            if (scores[i] >= 80)
//            {
//                sum += scores[i];
//            }
//        }

//        Console.WriteLine($"{scores.Length}명의 점수중 80점 이상의 총점(합계):{sum}");

////        디버그 f9(BP) -> f5(Start)->f11(함수나 메서드 있을시그안으로들어감) or f10 -> shift + f5(exit)

////        전체주석 Ctrl +k + c , 주석해제 Crtl +k + u

////        DotNet 설정에서 시작메인클래스 지정가능함

////ctrl + E + E = C#인터렉티브 실행 

////...뜰때 ctrl + . = 제공되는 가이드 확인가능

////ctrl + c + v 줄복사

////ctrl + ; 프로젝트창 열기

//    }
//}
