using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {

        static void Main(string[] args)
        {
            Triangle treq = new Triangle();
            Console.WriteLine("Введите 1-й катет:");
            treq.KatetOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2-й катет:");
            treq.KatetTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите гипотенузу:");
            treq.Gipotenuza = Convert.ToInt32(Console.ReadLine());            

            Console.WriteLine(String.Format("Площадь прямоугольного треугольника = {0}", treq.GetRectangulared() ? Convert.ToString(treq.GetArea()) : " Ошибка. Треугольник не прямоугольный."));
            Console.ReadKey();
        }
    }
}
