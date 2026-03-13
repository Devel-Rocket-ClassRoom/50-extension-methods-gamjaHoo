using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

////1
//string text = "hello";
//Console.WriteLine($"'hello' 대문자로 시작? {text.IsCapitalized()}");
//Console.WriteLine($"첫 글자 대문자: {text.Capitalize()}");
//Console.WriteLine($"뒤집기: {text.Reverse()}");
//static class StringExtensions
//{
//    static public bool IsCapitalized(this string text)
//    {
//        return char.IsUpper(text[0]);
//    }

//    static public string Capitalize(this string text)
//    {
//        string str;
//        str = text.Substring(0, 1).ToUpper() + text.Substring(1);
//        return str;
//    }

//    static public string Reverse(this string text)
//    {
//        char[] chars = text.ToCharArray();
//        Array.Reverse(chars);
//        return new string(chars);
//    }
//}


////2
//string original = "안녕하세요 반갑습니다 좋은 하루 되세요";
//Console.WriteLine($"원본: {original}");
//string result = original.Take(10).AddEllipsis().AddPrefix("[메시지] ").AddSuffix(" (더보기)");
//Console.WriteLine($"결과: {result}");
//static class StringChainExtensions
//{
//    static public string AddPrefix(this string text, string prefix)
//    {
//        return prefix + text;
//    }

//    static public string AddSuffix(this string text, string suffix)
//    {
//        return text + suffix;
//    }

//    static public string Take(this string text, int count)
//    {
//        if (text == null)
//        {
//            return text;
//        }
//        if(text .Length < count)
//        {
//            return text;
//        }
//        return text.Substring(0, count);
//    }

//    static  public string AddEllipsis(this string text)
//    {
//        return text + "...";
//    }
//}


//3
string[] names = { "철수", "영희", "민수" };
List<int> emptyList = new List<int>();

Console.WriteLine($"names 비어있음? {names.IsEmpty()}");
Console.WriteLine($"emptyList 비어있음? {emptyList.IsEmpty()}");
Console.WriteLine($"names에 요소 있음? {names.HasItems()}");

Console.WriteLine("\n이름 목록:");
names.ForEach(name => Console.WriteLine($"  - {name}"));
static class CollectionExtensions
{
    static public bool IsEmpty<T>(this ICollection<T> collection)
    {
        return collection.Count == 0; 
    }

    static public bool HasItems<T>(this ICollection<T> collection)
    {
        return collection.Count > 0; 
    }

    static public void ForEach<T> (this IList<T> list, Action<T> action)
    {
        foreach (var item in list)
        {
            action(item);
        }
    }
}