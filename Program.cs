using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = GetLenght;
            Console.WriteLine(myDelegate(r));
            myDelegate = GetArea;
            Console.WriteLine(myDelegate(r));
            myDelegate = GetVolume;
            Console.WriteLine(myDelegate(r));

            Console.ReadKey();
        }
        static double GetLenght(double r) => 2 * r * Math.PI;
        static double GetArea(double r) =>  r*r * Math.PI;
        static double GetVolume(double r) => (4/3)* r*r*r * Math.PI;
    }
}
