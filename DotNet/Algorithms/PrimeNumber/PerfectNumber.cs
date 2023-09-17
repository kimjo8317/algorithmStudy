////자신을 제외한 약수의 합이 자신과 같은 수
////6 : 1 + 2 + 3 = 6
////TODO 1부터 10000까지의 완전수와 개수를 출력
//class Algorithm_PerfectNumber
//{
//    static void Main()
//    {
//        int sum = 0; // 약수의 합계를 저장할 공간
//        int cnt = 0; // 완전수의 개수를 출력

//        for (int i = 1; i < 10000; i++)
//        {
//            sum = 0; // 매 반복마다 0으로 초기화
//            for (int j = 1; j < i; j++)
//            {
//                if (i % j == 0)
//                {
//                    sum += j; // 약수의 합계
//                }
//            }
//            if (i == sum)
//            {
//                System.Console.WriteLine("완전수 : {0}", i);
//                cnt++;
//            }
//        }

//        System.Console.WriteLine("완전수의 개수는 : {0}", cnt);
//    }
//}
