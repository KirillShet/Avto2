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
                do
                {
                    Console.WriteLine("Введите цифру соответсвующего транспорта: 1 - грузовик, 2 - автобус. ");
                    Console.WriteLine("Если же хотете завершить работу программы, то введите цифру 3.");
                    int var = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (var == 1)
                    {
                        gryz = new Class1();
                        gryz.info();
                        gryz.out_info();
                        Console.WriteLine();
                        gryz.move1();
                    }
                    else if (var == 2)
                    {
                        avtobus = new Class2();
                        avtobus.info();
                        avtobus.out_info();
                        Console.WriteLine();
                        avtobus.move1();
                    }
                    else if (var == 3)
                    {
                        osh = 2;
                    }
                    else if (var < 0 || var > 3)
                    {
                        Console.WriteLine("Вы ввели не то число.");
                        osh++;
                    }
                } while(osh == 0);
            } while (osh == 1);
        }
    }
}
