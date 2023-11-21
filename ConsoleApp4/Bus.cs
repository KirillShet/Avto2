using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Bus: Avto
    {
        private float massa;
        private float allmassa;
        protected override void info()
        {
            base.info();
            massa = 15000;
            Console.WriteLine("Введите максимальную доступную сокрость автобуса. (от 30 до 90)");
            do
            {
                osh = 0;
                scor = float.Parse(Console.ReadLine());
                if (scor < 30 || scor > 90)
                {
                    Console.WriteLine("Вы ввели неправлильное число.");
                    osh++;
                }
            } while (osh == 1);
            Console.WriteLine("Введите число, которое будет равно количеству человек в автобусе. (максимум 58)");
            do
            {
                osh = 0;
                chel = Convert.ToInt32(Console.ReadLine());
                if (chel > 58 || chel < 0)
                {
                    Console.WriteLine("Вы ввели неправлильное число.");
                    osh++;
                }
            } while (osh == 1);
            dop_massa = chel * 62;
            allmassa = massa + dop_massa;
            Console.Clear();
        }
        public void vivod_info()
        {
            info();
            out_info(allmassa);
            Console.WriteLine();
            move5(allmassa, massa);
        }
        protected override float F(float massa)
        {
            temp0 = 0.0013888f;
            base.F(massa);
            return result;
        }
    }
}
