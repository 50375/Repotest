using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqeg
{
    internal class linq_operators
    {
        public void linqop()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            int result = numbers.Min();
            Console.WriteLine(result);
        }
    }
}
