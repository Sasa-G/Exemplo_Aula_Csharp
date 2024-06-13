using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class ExemploLacoFor2
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);

                for(int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("inner: " + j);
                }

            }

        }
    }
}
