using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class ExemploContinue
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                if(i == 5)
                {
                    i++;
                    continue;

                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
