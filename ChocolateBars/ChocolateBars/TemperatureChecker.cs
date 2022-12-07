using System;
using System.Collections.Generic;
using System.Text;

namespace ChocolateBars
{
    class TemperatureChecker
    {
        /// <summary>
        /// Этот код выполняется каждые 3 минуты для проверки температуры.
        /// Если температура превышает 160 °C, необходимо запустить систему охлаждения.
        /// </summary>
        public void ThreeMinuteCheck()
        {
            if (IsNougatTooHot() == true)
            {
                DoCICSVentProcedure();
            }
        }

        /// <summary>
        /// Если температура нуги превышает 160 °C, она слишком горячая
        /// </summary>
        public bool IsNougatTooHot()
        {
            int temp = CandyBarMaker.CheckNougatTemperature();

            if (temp > 160)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /// <summary>
        ///  Выполнить процедуру вентиляции изолированной системы охлаждения (CICS).
        /// </summary>
        public void DoCICSVentProcedure()
        {
            TurbineController turbines = new TurbineController();
            turbines.CloseTripValve(2);

            IsolationCoolingSystem.Fill();
            IsolationCoolingSystem.Vent();
            CandyBarMaker.CheckAirSystem();
        }

    }
}
