using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class ExemploBreak2
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i <25; i = i + 2)
            {
                if(i == 20)
                {
                    break;
                }
                Console.WriteLine(" ");
                Console.WriteLine(" a sequencia de numero é: ");
                Console.Write(i);
            }
        }
    }
}
