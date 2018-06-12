using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesCoach.Shared.Enums
{
    class DoneStatus
    {
        public enum Status : int
        {
            Done,
            HalfDone,
            QuarterDone,
            Zero
        }

        public Status status;
    }
}
