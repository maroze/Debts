using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.25;

            Players player = new Players() { Name = "Игрок", Cash = 100 };

            Console.WriteLine("Добро пожаловать в наше Казино! Ваша вероятность " + odds);

            while (player.Cash > 0)
            {
                player.WriteMyInfo();

                Console.WriteLine("Сделайте ставку: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "")
                {
                    Console.WriteLine("Ты ничего не ввел");
                }

                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
 
                    if (pot > 0)
                    {
                        if (odds > random.NextDouble())
                        {
                            int winner = pot;
                            Console.WriteLine("Ты выиграл " + winner);
                            player.ReceiveCash(winner);
                        }

                        else
                        {
                            Console.WriteLine("Как жаль, удача покинула тебя");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Введите валидное число");
                }
            }
            Console.WriteLine("Казино всегда выигрывает");
        }
    }
}