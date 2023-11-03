using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Programm
    {
        static void Main()
        {
            int osh;
            Gruz gryz = new Gruz();
            Bus avtobus = new Bus();
            osh = 0;
            Console.WriteLine("Введите цифру соответсвующего транспорта: 1 - грузовик, 2 - автобус. ");
            Console.WriteLine("Если же хотете завершить работу программы, то введите цифру 3.");
            int var = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (var == 1)
            {
                gryz = new Gruz();
                gryz.info();
                gryz.out_info();
                Console.WriteLine();
                gryz.move5();
                Main();
            }
            else if (var == 2)
            {
                avtobus = new Bus();
                avtobus.info();
                avtobus.out_info();
                Console.WriteLine();
                avtobus.move5();
                Main();
            }
            else if (var == 3)
            {
                Console.WriteLine("Конец программы.");
            }
            else if (var < 0 || var > 3)
            {
                Console.WriteLine("Вы ввели не то число.");
                Main();
            }
        }
    }
}
