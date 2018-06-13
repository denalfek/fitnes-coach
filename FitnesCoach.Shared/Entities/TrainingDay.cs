using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesCoach.Shared.Entities
{
    class TrainingDay
    {
        public int UserId { get; set; }

        public int DayNumber { get; set; }

        public string TrainingPlan { get; set; }

        public int Health { get; set; }

        public int Status { get; set; }

        public string ActivityType { get; set; }
    }
}
