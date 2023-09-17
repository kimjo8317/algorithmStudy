//using System;
////TODO 특정수를 입력 받아서 , 소수인지 아닌지 판별하는 로직만들기 
//// 5는 소수이다,1과 5만을 약수로 가짐
//// 6은 소수가 아니다, 1과 6만이 아닌 추가로 2와 3을 약수로 가짐
//// 2부터 해당 수까지 나머지값을 구해서 나머지값이 0일때 ,나눈 수가 해당 수라면 소수


///// <summary>
///// 소수 알고리즘 : 자연수 중에서 1과 자기 자신만을 약수로 가지는 자연수는 소수라고함
///// ex)2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53,
/////		59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109
///// </summary>
//class PrimeNumber
//{
//	static void Main()
//	{
//		//input
//		var number = 0;
//        Console.Write("수 입력: _\b");
//        number = Convert.ToInt32(Console.ReadLine());

//        //process = primeNumber가 2부터 n까지 나누어 떨어지는 수가 발생할 때까지 반복
//        var i = 1;
//		do
//		{
//			i = i + 1; //2부터 n까지 비교

//		} while (number % i != 0); //소수는 number로만 나누어 떨어짐

//        Console.WriteLine($"{number} % {i} = {number % i}");

//		//output
//		if (number == i)
//		{
//            Console.WriteLine("소수");
//        }
//		else
//		{
//            Console.WriteLine("소수 아님");
//        }
//    }
//}