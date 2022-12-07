using System;
using System.Collections.Generic;
using System.Text;

namespace BeeManufacture
{
    class Bee
    {
        public virtual float CostPerShift { get; }
        public string Job { get; private set; }

        public Bee(string job)
        {
            Job = job;
        }

        /// <summary>
        /// Определяет достаточно ли меда для каждого вида работ,
        /// если это так, вызывает метод DoJob
        /// </summary>
        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected virtual void DoJob(){}
    }
}
