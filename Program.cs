using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        /// <summary>
        ///Отсортировать одномерный масив по возрастанию и по убыванию
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            Array.Sort(people);
            foreach (var el in people)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("");
            Array.Reverse(people);
            foreach (var el in people)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}
