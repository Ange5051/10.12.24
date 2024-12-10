using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отсортировать одномерный масив по возрастанию и по убыванию
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
