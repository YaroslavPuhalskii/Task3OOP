using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> p = new List<Person>()
            {
                new Person("A", 1),
                new Person ("B", 2),
                new Person("D",4),
                new Person("C",3)
            };

            #region Сортировка 
            var sorted = p.OrderBy(x => x.Id);
            var sorteda = p.OrderByDescending(x => x.Id); ;
            foreach (Person p1 in sorted)
            {
                Console.Write(p1.Id);
            }
            foreach (Person p1 in sorteda)
            {
                Console.Write(p1.name);
            }
            #endregion
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            #region Без повторяющихся элментов
            List<Person> p2 = new List<Person>()
            {
                new Person("A", 1),
                new Person ("B", 2),
                new Person("D",4),
                new Person("D",3)
            };

            var b = p2.Select(x => x.name).Distinct().ToList();

            foreach (var item in b)
            {
                Console.Write(item);
            }
            #endregion
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");



            var c = p.Union(p2);
            foreach (var item1 in c)
            {
                Console.Write(item1.name);
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            



            Console.ReadLine();
          
        }
    }
}
