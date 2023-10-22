using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
   
        public class Tank
        {
            private string tankName;
            private int ammunition;
            private int armorLevel;
            private int maneuverability;

            public Tank(string name)
            {
                tankName = name;
                List<int> uniqueValues = GetUniqueValues();
                ammunition = uniqueValues[0];
                armorLevel = uniqueValues[1];
                maneuverability = uniqueValues[2];
            }

            private List<int> GetUniqueValues()
            {
                List<int> values = Enumerable.Range(0, 101).OrderBy(x => Guid.NewGuid()).ToList();
                // Перетасовка уникальных значений от 0 до 100
                return values.Take(3).ToList();
            }

            public override string ToString()
        {
            return $"{tankName} - Боекомплект: {ammunition}%, Уровень брони: {armorLevel}%, Уровень маневренности: {maneuverability}%";
        }

        public static bool operator ^(Tank tank1, Tank tank2)
        {
            int score = 0;
            if (tank1.ammunition > tank2.ammunition)
                score++;
            if (tank1.armorLevel > tank2.armorLevel)
                score++;
            if (tank1.maneuverability > tank2.maneuverability)
                score++;

            return score >= 2;
        }
    }
}
