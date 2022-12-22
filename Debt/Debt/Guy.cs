using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    class Guy
    {
        public string Name;
        public double Cash;

        /// <summary>
        /// Выводит имя и сумму в консоль
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine("У " + Name + " " + Cash + " $");
        }

        /// <summary>
        /// Выдает часть моих денег, удаляя их из кармана (или выводит на консоль 
        /// сообщение о том, что денег недостаточно) 
        /// </summary>
        /// <param name="amount">Денежная сумма</param>
        /// <returns>
        /// Сумма денег, взятая из кармана, или 0, если денег не хватает
        /// (или если сумма недействительна).
        /// </returns>
        public double GiveCash(double amount)
        {
            if (amount == 0)
            {
                Console.WriteLine("Ты не можешь занять " + amount + " у " + Name);
                return 0;
            }

            if (amount > Cash)
            {
                Console.WriteLine(amount + " это больше, чем есть у " + Name);
                return 0;
            }

            Cash -= amount;

            return amount;
        }

        /// <summary>
        /// Получает часть своих денег, добавляя их в кармана (или выводит на консоль 
        /// сообщение о том, что сумма не действительна) 
        /// </summary>
        /// <param name="amount">Денежная сумма</param>
        public void ReceiveCash(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " говорит: " + amount + " это не та сумма, которую я возьму");
            }

            else
            {
                Cash += amount;
            }
            
        }
    }
}
