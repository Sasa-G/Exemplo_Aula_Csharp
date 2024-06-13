using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class ExemploBreakWhile
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while(1 < 10)
            {
                Console.WriteLine(i++);
                if(i == 8)
                {
                    break;
                }
            }
        }
    }
}
