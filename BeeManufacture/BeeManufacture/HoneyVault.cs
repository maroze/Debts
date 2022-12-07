using System;
using System.Collections.Generic;
using System.Text;

namespace BeeManufacture
{
    static class HoneyVault
    {
        const float NECTAR_CONVERSION_RATIO = .19f;
        const float LOW_LEVEL_WARNING = 10f;        
        
        private static float honey = 25f;
        private static float nectar = 100f;
        
        public static string StatusReport
        {
            get
            {
                if (honey < LOW_LEVEL_WARNING)
                {
                    return $"LOW HONEY: {honey}\nADD A HONEY MANUFACTURER";
                }
                else if (nectar < LOW_LEVEL_WARNING)
                {
                    return $"LOW NECTAR: {nectar}\nADD A NECTAR COLLECTOR";
                }
                else
                {
                    return $"HONEY: {honey}\nNECTAR: {nectar}";
                }
            }
        }

        public static void CollectNectar(float amount)
        {

            if (amount >= 0f)
            {
                nectar += amount;
            }
        }

        /// <summary>
        /// Пчелы выполняют свою работу, что приводит к уменьшению количества нектара и
        ///увеличению количества меда в хранилище.
        /// </summary>
        /// <param name="amount">Количество нектара</param>
        public static void ConvertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            if (nectarToConvert > nectar)
            {
                nectarToConvert = nectar;
            }
            nectar -= nectarToConvert;
            honey += nectarToConvert * NECTAR_CONVERSION_RATIO;
        }


        /// <summary>
        ///Метод возвращает true только в том случае, если 
        ///в улье хватает меда для выполнения его работы.
        /// </summary>
        /// <param name="amount">Количество мёда</param>
        /// <returns></returns>
        public static bool ConsumeHoney(float amount)
        {
            if (amount <= honey)
            {
                honey -= amount;
                return true;
            }
            return false;

        }
    }
}
