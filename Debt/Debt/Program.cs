using System;

namespace Debt
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Джо", Cash = 500 };
            Guy bob = new Guy() { Name = "Боб", Cash = 600 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Введите сумму: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;

                if (double.TryParse(howMuch, out double amount))
                {
                    Console.Write("Кто должен дать денег: ");
                    string whichGuy = Console.ReadLine();

                    if (whichGuy == "Джо")
                    {
                        double cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }

                    else if (whichGuy == "Боб")
                    {
                        double cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    
                    else
                    {
                        Console.WriteLine("Введите Джо или Боб");
                    }
                }

                else
                {
                    Console.WriteLine("Введите сумму.");
                }
            }

        }
    }
}
