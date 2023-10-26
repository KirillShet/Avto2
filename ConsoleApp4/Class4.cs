using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class4
    {
        static void Main()
        {
            int osh;
            do
            {
                Class1 gryz = new Class1();
                Class2 avtobus = new Class2();
                osh = 0;
                Console.WriteLine("Введите цифру соответсвующего транспорта: 1 - грузовик, 2 - автобус.");
                int var = Convert.ToInt32(Console.ReadLine());
                if (var == 1)
                {
                    gryz = new Class1();
                    gryz.info();
                    gryz.out_info();
                    gryz.move1();
                }
                else if (var == 2)
                {
                    avtobus = new Class2();
                    avtobus.info();
                    avtobus.out_info();
                }
                else if (var < 0 || var > 2)
                {
                    Console.WriteLine("Вы ввели не то число.");
                    osh++;
                }
            } while (osh == 1);
        }
    }
}
