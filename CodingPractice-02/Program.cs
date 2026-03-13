using System;

////1
//Console.WriteLine("안녕하세요".First(3));
//static class StringExtensions
//{
//    static public  string First(this string text, int count)
//    {
//        if(text == null || text.Length == 0)
//        {
//            return text;
//        }
//        if(count > text.Length)
//        {
//            return text;
//        }
//        return text.Substring(0, count);
//    }
//}

//2
Player player = new Player();
player.Name = "용사";
player.Level = 5;
player.Experience = 150;
Console.WriteLine(player.GetInfo());
Console.WriteLine($"레벨없 가능: {player.CanLevelUp()}");
player.LevelUp();
Console.WriteLine($"용사(이)가 레벨업! 현재 레벨: {player.Level}");
Console.WriteLine(player.GetInfo());
class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
}

static class PlayerExtensions
{
    static public string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Experience}";
    }

    static public bool CanLevelUp(this Player player)
    {
        return player.Experience > 100;
    }

    static public void LevelUp(this Player player)
    {
        player.Experience -= 100;
        player.Level++;
    }
}