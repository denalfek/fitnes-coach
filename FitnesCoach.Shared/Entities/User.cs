using System;
using System.Collections.Generic;
using System.Text;

namespace FitnesCoach.Shared.Entities
{
    class User
    {
        public int Id { get; set; }

        public string Name { get; set; } // имя

        public string Email { get; set; } // почта

        public int Age { get; set; } // возраст

        public bool Sex { get; set; } // тут думал стринг или даже чар, но поскольку вида 2 М и Ж то остановился на буле

        public int Height { get; set; } // рост
        
        public int Weight { get; set; } // вес

        public int BMI { get; set; } // ИМТ и кстати, возможно нам не нужно хранить значения роста и веса

        public int Squat { get; set; } // приседания

        public int PullUps { get; set; } // подтягивания

        public int PushUps { get; set; } // отжимания
    }
}
