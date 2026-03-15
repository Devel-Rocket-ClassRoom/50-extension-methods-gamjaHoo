using System;
using System.Collections.Generic;

namespace Shuffle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== 컬렉션 셔플 테스트 ===\n");

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("[숫자 리스트 셔플]");
            Console.WriteLine("원본: " + string.Join(", ", numbers));

            numbers.Shuffle();
            Console.WriteLine("셔플: " + string.Join(", ", numbers));
            Console.WriteLine();

            var cards = new List<string> { "♠A", "♥K", "♦Q", "♣J" };
            Console.WriteLine("[카드 덱 셔플]");
            Console.WriteLine("원본: " + string.Join(", ", cards));

            cards.Shuffle();
            Console.WriteLine("셔플: " + string.Join(", ", cards));
            Console.WriteLine();

            var students = new List<string>
        {
            "김철수", "이영희", "박민수", "최지연", "정우진"
        };

            Console.WriteLine("[학생 순서 무작위 배치]");
            Console.WriteLine("원본: " + string.Join(", ", students));

            students.Shuffle();
            Console.WriteLine("셔플: " + string.Join(", ", students));
        }
    }
}