using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class ExemploMatriz2
    {
        public static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
        }
    }
}
