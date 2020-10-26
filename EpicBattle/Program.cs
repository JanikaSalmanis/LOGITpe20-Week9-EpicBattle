using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Bilbo Baggins", "Lara Croft" };
            string[] villains = { "Voldemort", "Darth Vader", "Sauron", "Joker", "Harley Queen" };
            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            Console.WriteLine($"{hero} will fight {villain}");

            int heroHP = GenerateHP();
            int villianHP = GenerateHP();
            Console.WriteLine($"{hero} with {heroHP} Hp will fight {villain}" + $" { villianHP} HP");
            while (heroHP > 0 && villianHP > 0)
            {

                heroHP = heroHP - Hit(hero);
                villianHP = villianHP - Hit(villain);
            }
            GetWinner(heroHP, villianHP);
        }

        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }

        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }
        public static int Hit(String character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}!");
            if(strike == 3)
            {
                Console.WriteLine($"Awesome! {character} made a critical hit!");
            }else if(strike == 0)
            {
                Console.WriteLine($"Bad luck! {character} missed the target!");
            }
            return strike;
        }
        public static void GetWinner(int heroHP, int VillainHP)
        {
          if(heroHP == 0)
            {
                Console.WriteLine("Dark site wins!");
            }else 
            {
                Console.WriteLine($"Hero saves the day!");
            }
        }
    }
}
