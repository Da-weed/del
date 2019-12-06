using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wamshale_consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            var Month = Enumerable.Range(1,12);
            foreach (var item in Month)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
