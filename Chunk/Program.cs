using System;
using System.Collections.Generic;
using System.Linq;

namespace Chunk
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== 컬렉션 청킹 테스트 ===\n");

            Console.WriteLine("[숫자를 3개씩 그룹화]");
            var numbers = Enumerable.Range(1, 10);

            foreach (var chunk in numbers.Chunk(3))
            {
                Console.WriteLine($"[{string.Join(", ", chunk)}]");
            }

            Console.WriteLine();

            Console.WriteLine("[학생들을 2명씩 팀 구성]");
            var students = new List<string>
        {
            "김철수", "이영희",
            "박민수", "최지연",
            "정우진"
        };

            int teamNumber = 1;
            foreach (var team in students.Chunk(2))
            {
                Console.WriteLine($"팀 {teamNumber++}: {string.Join(", ", team)}");
            }

            Console.WriteLine();

            Console.WriteLine("[페이지별로 5개씩 나누기]");
            var pages = Enumerable.Range(1, 25);

            int page = 1;
            foreach (var pageItems in pages.Chunk(5))
            {
                Console.WriteLine($"페이지 {page++}: {string.Join(", ", pageItems)}");
            }
        }
    }
}