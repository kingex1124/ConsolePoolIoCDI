using ConsolePoolIoCDI.Instance;
using ConsolePoolIoCDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePoolIoCDI
{
    class Program
    {
       
        static void Main(string[] args)
        {
            UnityContainer.Register<ITester, Tester>();
            //UnityContainer.Register<ITester, Tester2>();

            ITester tester = UnityContainer.Resolve<ITester, Tester2>();


            var re = tester.Cal(5, 3);

            tester = new Tester2();

            var re2 = tester.Cal(5, 3);
        }
    }
}
