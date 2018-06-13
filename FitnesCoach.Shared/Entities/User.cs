using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesCoach.Shared.Entities
{
    class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public int Sex { get; set; }

        public int Height { get; set; }
        
        public int Weight { get; set; }

        public int BMI { get; set; } // ИМТ

        public int Squat { get; set; }

        public int PullUps { get; set; }

        public int PushUps { get; set; }
    }
}
