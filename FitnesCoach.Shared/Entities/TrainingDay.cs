using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesCoach.Shared.Entities
{
    class TrainingDay
    {
        public int UserId { get; set; }

        public int DayNumber { get; set; }

        public string TrainingPlan { get; set; } // как это сделать с json я пока не понял, помню serialized/deserialized

        public int Health { get; set; } // самочувствие

        public bool Status { get; set; } // выполнено-невыполнено

        public string ActivityType { get; set; } // вид активности
    }
}
