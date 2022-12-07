using System;
using System.Collections.Generic;
using System.Text;

namespace CafeJoh
{
    class MenuItem
    {
        public static Random randomizer = new Random();

        public string[] Proteins = { "Жаренное мясо", "Салями", "Индейка",
"Ветчина", "Пастрами", "Тофу"};
        public string[] Condiments = {"желтая горчица", "коричневая горчица",
"медовая горчица", "майонез", "релиш", "французская заправка" };
        public string[] Breads = { "ржаной хлеб", "белый хлеб", "пшеничный хлеб", "пумперникель", "булочка" };

        public string Description = "";
        public string Price;
        
        public void Generate()
        {
            string randomProteins = Proteins[randomizer.Next(Proteins.Length)];
            string randomCondiments = Condiments[randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[randomizer.Next(Breads.Length)];

            decimal banknotes = randomizer.Next(50, 150);
            decimal cents = randomizer.Next(1, 101);
            decimal price = banknotes + (cents * .01M);
            //Параметр метода ToString определяет формат.В данном случае формат "c" приказывает ToString
            //отформатировать значение с локальной денежной единицей:
            //в США будет выводиться знак $, в Великобритании — ₤, в Европе — € и т. д.
            Price = price.ToString("c");
            Description = randomProteins +" "+ randomCondiments +" "+ randomBreads;
        }
    }
}
