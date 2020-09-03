using ConsolePoolIoCDI.Instance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePoolIoCDI.Interface
{
    public class Tester2 : ITester
    {
        public int Cal(int a, int b)
        {
            return a - b;
        }
    }
}
