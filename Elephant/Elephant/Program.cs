using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephants two = new Elephants() { Name = "Lucinda", EarSize = 33 };
            Elephants one = new Elephants() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Нажмите 1 для Lloyd, 2 для Lucinda, 3 поменять ссылки");

            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("Вы нажали: " + input);

                if (input == '1')
                {
                    Console.WriteLine("Вызываем lloyd.WhoAmI()\n" + one.WhoAmI());
                }

                else if (input == '2')
                {
                    Console.WriteLine("Вызываем lucinda.WhoAmI()\n" + two.WhoAmI());
                }

                else if (input == '3')
                {
                    Elephants three;
                    three = two;
                    two = one;
                    one = three;

                    Console.WriteLine("Ссылки были заменены местами");
                }

                else if (input == '4')
                {
                    one = two;
                    one.EarSize = 4321;
                    Console.WriteLine(two.WhoAmI());
                }

                else if (input == '5')
                {
                    two.SpeakTo(one, "Hi, Lloyd!");
                }

                else
                {
                    return;
                }
            }
        }

    }
}

