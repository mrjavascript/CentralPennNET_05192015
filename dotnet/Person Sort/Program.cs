using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Sort
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name)
        {
            this.Name = Name;
        }
    }

    class PersonCompare : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return String.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Tom Brady");
            Person person2 = new Person("David Letterman");
            List<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);

            // Sort the list
            // persons.Sort(new PersonCompare());
            persons.Sort(delegate(Person p, Person p2)
            {
                return String.Compare(p.Name, p2.Name, StringComparison.Ordinal);
            });
            // persons.OrderBy(x => x.Name);

            /*
            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }
             */
            persons.ForEach( (p) => Console.WriteLine(p.Name));

            Console.ReadLine();
        }
    }
}
