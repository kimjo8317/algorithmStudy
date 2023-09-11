////TODO 1부터 1000까지의 정수 중에 13의 배수의 개수는 몇개일까?
//using System;
//using System.Linq;

//class CountAlgorithm
//    //개수 알고리즘: 주어진 범위에 주어진 조건에 해당하는 자료들의 개수
//{
//    static void Main()
//    {
//        //[1]Input 1~1000 까지의 데이터 
//        var numbers = Enumerable.Range(1, 1_000).ToArray();//ToArray 메서드로 정수형 배열로 바꿈
//        //Linq사용해서 사용해서 numbers배열에 1~1000까지의 숫자를 담음
//        int count = 0; //개수를 저장할 변수 0으로 초기화(or default사용(기본값)

//        //[2]Process = 개수알고리즘 : 주어진 범위에 주어진 조건(필터링)
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (numbers[i] % 13 == 0)
//            {
//                count++; //Count
//            }
//        }

//        //[3]Output
//        Console.WriteLine($"1부터 1000까지의 정수 중에 13의 배수의 개수는 몇개일까?:{count}");

//    }
//}
////Enumerable.Range(1, 1_000).ToArray().Where(n => n % 13 == 0).Count()
////Enumerable.Range(1, 1_000).ToArray().Count(n => n % 13 == 0)