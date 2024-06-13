using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class exemploBreakWhile2
    {
        public static void Main(string[] args)
        {
            int i = 10;
            while(i < 20)
            {
                Console.WriteLine(i--);
                if(i == -10)
                {
                    break;
                }
            }
        }
    }
}
