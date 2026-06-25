// Learing C# from : https://learn.microsoft.com/
// Module : Add looping logic to your code using the do-while and while statements in C#
// Unit 3: Exercise - Complete a challenge activity using do and while iteration statements.
// Challenge : Role playing game battle challenge

using System;

namespace HeroMonsterGame
{
    static class Program
    {
        static void Main()
        {

            int hero = 10;
            int monster = 10;

            Random attack = new Random();

            do
            {
                int damage = attack.Next(1, 11);
                monster -= damage;
                if (monster < 0) monster = 0;
                Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monster} health.");

                if (monster <= 0) continue;

                damage = attack.Next(1, 11);
                hero -= damage;
                if (hero < 0) hero = 0;
                Console.WriteLine($"Hero was damaged and lost {damage} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
        }
    }
}