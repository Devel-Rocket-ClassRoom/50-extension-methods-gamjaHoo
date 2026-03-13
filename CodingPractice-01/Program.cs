using System;
using System.Linq;
using System.Runtime.CompilerServices;

////1
//Console.WriteLine($"단어 개수: {StringHelper.CountWords("안녕하세요 반갑습니다.")}");
//static class StringHelper
//{
//    static public int CountWords(string text)
//    {
//        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
//    }
//}

////2
//Console.WriteLine($"단어 개수: {"안녕하세요 반갑습니다.".CountWords()}");
//static class StringExtensions
//{
//    static public int CountWords(this string text)
//    {
//        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
//    }
//}


////3
//int a = 10;
//int b = 7;
//int c = 3;
//int times = 5;

//Console.WriteLine($"{a}은(는) 짝수인가? {a.IsEven()}");
//Console.WriteLine($"{b}은(는) 홀수인가? {b.IsOdd()}");
//Console.WriteLine($"{c}을 {times}번 반복: {c.Repeat(times)}");
//static class IntExtensions
//{
//    static public bool IsEven(this int number)
//    {
//        return number % 2 == 0; 
//    }

//    static public bool IsOdd(this int number)
//    {
//        return number % 2 != 0;
//    }

//    static public string Repeat(this int number, int times)
//    {
//        return string.Concat(Enumerable.Repeat(number.ToString(), times));
//    }
//}