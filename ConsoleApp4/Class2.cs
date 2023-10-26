using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class2: Class1
    {
        public override void info()
        {
            Console.WriteLine("Количество бензина в баке: ");
            bak = float.Parse(Console.ReadLine());
            max_bak = bak;
            Console.WriteLine("Расход топлива за 1 час езды: ");
            ras = float.Parse(Console.ReadLine());
            Console.WriteLine("Сколько проехал до этого: ");
            mov = float.Parse(Console.ReadLine());
            massa = 15000;
            Console.WriteLine("Введите число, которое будет равно количеству человек в автобусе. (максимум 58)");
            do
            {
                osh = 0;
                dop_massa = float.Parse(Console.ReadLine());
                if (dop_massa > 58 || dop_massa < 0)
                {
                    Console.WriteLine("Вы ввели неправлильное число.");
                    osh++;
                }
            } while (osh == 1);
            Console.WriteLine("Введите максимальную доступную сокрость грузовика. (от 30 до 90)");
            do
            {
                scor = float.Parse(Console.ReadLine());
                if (scor < 30 || scor > 90)
                {
                    Console.WriteLine("Вы ввели неправлильное число.");
                    osh++;
                }
            } while (osh == 1);
            Console.Clear();
        }
        public override void out_info()
        {
            Console.WriteLine("Количество бензина в баке: " + bak);
            Console.WriteLine("Расход бензина за 1 час езды: " + ras);
            Console.WriteLine("Расстояние, которое проехал до этого момента: " + mov);
            Console.WriteLine("Максимальная масса транспорта: " + (massa + (dop_massa * 50)));
        }
    }
}
