using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;

namespace Day7_Tanks
{
        class Program
        {
            static void Main(string[] args)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Бой №{i}:");

                    Tank t34 = new Tank("Т-34");
                    Tank pantera = new Tank("Pantera");

                    Console.WriteLine(t34);
                    Console.WriteLine(pantera);

                    if (t34 ^ pantera)
                    {
                        Console.WriteLine($"Т-34 побеждает над Pantera!");
                    }
                    else
                    {
                        Console.WriteLine($"Pantera побеждает над Т-34!");
                    }

                    Console.WriteLine(); // Добавляем пустую строку для разделения симуляций
                }

                Console.ReadLine();
            }
        }
    }