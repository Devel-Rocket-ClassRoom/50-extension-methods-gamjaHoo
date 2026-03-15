using System;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== 회문 판별 테스트 ===");

            string[] tests =
            {
            "토마토",
            "기러기",
            "level",
            "Level",
            "A man, a plan, a canal: Panama",
            "race a car",
            "hello",
            "가나다",
            ""
        };
            foreach (var text in tests)
            {
                Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
            }
        }
    }
}