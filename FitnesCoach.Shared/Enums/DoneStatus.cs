using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesCoach.Shared.Enums
{
    class DoneStatus
    {
        public enum Status : int
        {
            Done, // полностью выполнено
            HalfDone, // половина 
            QuarterDone, // всего лишь четверть
            Zero // нихера
        }

        public Status status;
    }
}
