using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        protected float bak;
        protected float ras;
        protected float mov;
        public float time;
        protected float max_bak;
        protected float massa;
        protected float dop_massa;
        protected int osh;
        protected float scor;
        protected int km;
        protected float proh;
        protected float vrem;
        protected float dop;
        protected float top;
        public virtual void info()
        {
            Console.WriteLine("Количество бензина в баке: ");
            bak = float.Parse(Console.ReadLine());
            max_bak = bak;
            Console.WriteLine("Расход топлива за 1 час езды: ");
            ras = float.Parse(Console.ReadLine());
            Console.WriteLine("Сколько проехал до этого: ");
            mov = float.Parse(Console.ReadLine());
            massa = 38000;
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
            Console.Clear();
        }
        public virtual void out_info()
        {
            Console.WriteLine("Количество бензина в баке: " + bak);
            Console.WriteLine("Расход бензина за 1 час езды: " + ras);
            Console.WriteLine("Расстояние, которое проехал до этого момента: " + mov);
            Console.WriteLine("Максимальная масса транспорта: " + (massa + dop_massa));
        }

        public virtual void move1() 
        {
            int nedos = 0;
            float time2 = 0;
            float time = 0;
            scor = 80;
            float t = 0;
            int vibor;
            max_bak = bak;
            do
            {
                osh = 0;
                proh = 0;
                vrem = 0;
                Random rnd = new Random();
                km = rnd.Next(1000, 15000);
                time = km / scor;
                time2 = (ras * 4) / 5;
                t = (float)Math.Round((time + float.Parse("0,002778")) * time2, 2);
                Console.WriteLine("Авто проехало:" + km);
                if (bak < t)
                {
                    osh++;
                    mov += (float)Math.Round((bak / time2) * scor, 2);
                    proh = (float)Math.Round((km - ((bak / time2) * scor)), 2);
                    vrem = (float)Math.Round((bak / time2) * scor, 2);
                    Console.WriteLine(t);
                    dop = (float)Math.Round(t - bak, 2);
                    Console.WriteLine("Проехал всего: " + mov + " Не доехал от нужного расстояния: " + proh);
                    Console.WriteLine("Для того, чтобы доехать до точки не хватает бензина: " + dop);
                    do
                    {
                        Console.WriteLine("Если вы хотите заправить бак, то напишиту цифру 1, если нет - 2");
                        vibor = Convert.ToInt32(Console.ReadLine());
                        if (vibor == 1)
                        {
                            top = float.Parse(Console.ReadLine());
                            if (top <= max_bak)
                            {
                                if (top >= dop)
                                {
                                    nedos = 0;
                                    bak = (float)Math.Round(bak + top, 2);
                                    osh--;
                                    bak = bak - t;
                                }
                                else if (top < dop)
                                {
                                    nedos++;
                                    dop = (float)Math.Round(dop - top, 2);
                                    mov += (float)Math.Round((top / time2) * scor, 2);
                                    proh = (float)Math.Round((km - ((bak / time2) * scor + (top / time2) * scor)), 2);
                                    Console.WriteLine("Осталось проехать до конца пути: " + proh + " Нехватает топлива: " + dop);
                                    bak = (float)Math.Round(bak + top, 2);
                                    vrem += (float)Math.Round((top / time2) * scor, 2);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Бак не может столько вместить.");
                                nedos++;
                            }
                        }
                        else if (vibor == 2)
                        {
                            Console.WriteLine("Вы проехали:" + mov + " До конечной точки осталось: " + proh);
                            nedos = 0;
                            osh++;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неправильное чисило или ввели букву.");
                        }
                    } while (nedos > 0);
                }
                else
                {
                    mov += mov + km;
                    bak -= t;
                    Console.WriteLine("Осталось бензина: " + bak);
                }
            } while (osh == 0);
        }
    }
}
