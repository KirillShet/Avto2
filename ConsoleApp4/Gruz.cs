using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace ConsoleApp4
{
    internal class Gruz: Avto
    {

        protected override void info()
        {
            base.info();
            massa = 38000;
            Console.WriteLine("Введите максимальную доступную сокрость грузовика. (от 30 до 60)");
            do
            {
                osh = 0;
                scor = float.Parse(Console.ReadLine());
                if (scor < 30 || scor > 60)
                {
                    Console.WriteLine("Вы ввели неправлильное число.");
                    osh++;
                }
            } while (osh == 1);
            Console.WriteLine("Введите число, которое будет равно дополнительному весу. (максимум 6350)");
            do
            {
                osh = 0;
                dop_massa = float.Parse(Console.ReadLine());
                if (dop_massa > 6350 || dop_massa < 0)
                {
                    Console.WriteLine("Вы ввели неправлильное число.");
                    osh++;
                }
            } while (osh == 1);
            allmassa = massa + dop_massa;
            Console.Clear();
        }
        public override void vivod_info()
        {
            info();
            base.vivod_info();
        }
    }
}
