using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class ExemploBreak
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i <10; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

    }
}
