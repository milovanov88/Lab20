using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_1
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №20");
            Console.WriteLine("Задайте радиус окружности");
            double R;
            MyDelegate myDelegate = circumference;
            myDelegate += circleArea;
            myDelegate += sphereVolume;
            myDelegate(R = Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
        static double circumference(double R)
        {
            double D = 2 * Math.PI * R;
            Console.WriteLine("длина окружности равна: {0}", D);
            return D;
        }
        static double circleArea(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Площадь круга равна: {0}", S);
            return S;
        }
        static double sphereVolume(double R)
        {
            double V = 4 * Math.PI * Math.Pow(R, 3) / 3;
            Console.WriteLine("Объем шара равен: {0}", V);
            return V;
        }

    }
}