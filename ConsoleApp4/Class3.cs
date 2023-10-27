using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class3
    {
        protected float bak;
        protected float ras;
        protected float mov;
        protected float scor;
        protected float massa;
        protected float dop_massa;
        protected float max_bak;

        public virtual void info()
        {
            Console.WriteLine("Количество бензина в баке: ");
            bak = float.Parse(Console.ReadLine());
            max_bak = bak;
            Console.WriteLine("Расход топлива за 1 час езды: ");
            ras = float.Parse(Console.ReadLine());
            Console.WriteLine("Сколько проехал до этого: ");
            mov = float.Parse(Console.ReadLine());
        }
        public virtual void out_info()
        {
            Console.WriteLine("Количество бензина в баке: " + bak);
            Console.WriteLine("Расход бензина за 1 час езды: " + ras);
            Console.WriteLine("Расстояние, которое проехал до этого момента: " + mov);
            Console.WriteLine("Максимальная масса транспорта: " + (massa + dop_massa));
            Console.WriteLine("Максимальная скорость автобуса: " + scor);
        }
    }
}
