using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        /// <summary>
        /// Подсчитать колличество числа со значением 5 в одномерном масиве
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int [] omas={5,7,1,9,5,3,6,5,5};
            int count = 0;
            foreach (var el in omas) 
            {
                if (el==5)
                            {count++;}
            }
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
