using System;
using System.Collections.Generic;
using System.Text;

namespace Elephant
{
    class Elephants
    {
        public string Name;
        public double EarSize;

        /// <summary>
        /// Информация о слоне
        /// </summary>
        /// <returns>Возвращает имя и размер ушей слона</returns>
        public string WhoAmI()
        {
            return "Моё имя " + Name + "\n" + "Размер моих ушей " + EarSize + " см";
        }

        /// <summary>
        /// Метод для прослушивания сообщения
        /// </summary>
        /// <param name="message">текст сообщения</param>
        /// <param name="whoSaid">отправитель сообщения</param>
        /// <returns>в первой части адресат прослушал сообщение, во второй
        /// имя отправителя и содержание сообщения</returns>
        public void HearMessage(string message, Elephants whoSaidIt)
        {
            Console.WriteLine( Name + " прослушал сообщение\n" + whoSaidIt.Name + " отправил это сообщение: " + message);
        }

        /// <summary>
        /// Метод для отправки сообщения
        /// </summary>
        /// <param name="whoToTalkTo">отправитель</param>
        /// <param name="message">текст сообщения</param>
        public void SpeakTo(Elephants whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
