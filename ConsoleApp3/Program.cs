using ConsoleApp3.classes;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Person p1 = new Person("Anna","Pierwsza");
            Person p2 = new Person("Maria", "Druga");
            Person p3 = new Person("Tomasz", "Trzeci");

            persons.Add(p1);
            persons.Add(p1);
            persons.Add(p2);

            Console.WriteLine(persons.Count);//3
            Console.WriteLine(persons[1].lastName);//pierwsza
            foreach (Person p in persons)
            {
                Console.WriteLine(p.firstName + " " + p.lastName);
            }
            persons.Insert(0, p2);
            foreach (Person p in persons)
            {
                Console.WriteLine(p.firstName + " " + p.lastName);
            }
            Console.WriteLine();

            persons.Add(new Person("Krystyna","Kowalska"));
            Console.WriteLine(persons.Count);//5

            Console.WriteLine(persons.Contains(p1));//True
            Console.WriteLine(persons.Contains(p3));//False

            Console.WriteLine(persons.IndexOf(p1));//1
            Console.WriteLine(persons.IndexOf(p3));//-1

            persons.Remove(p1);
            Console.WriteLine(persons.IndexOf(p1));//1
            Console.WriteLine(persons.Count);//4
            Console.WriteLine();

            persons.RemoveAt(0);
            foreach(Person p in persons)
            {
                Console.WriteLine(p.firstName + " " + p.lastName);
            }

            Console.WriteLine();

            string[] names = { "Janusz", "Ania" };
            List<string> stringsList = new List<string>();

            stringsList.AddRange(names);
            foreach (string s in stringsList)
            {
                Console.WriteLine(s + " ");
            }

            Console.WriteLine();

            string[] namesList = stringsList.ToArray();
            foreach (string n in namesList)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            string[] cities = { "Poznań", "Gniezno" };
            stringsList.AddRange(cities);
            foreach (string n in namesList)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine();

            stringsList.InsertRange(1, cities);//Janusz Poznań Gniezno Anna

            stringsList.Insert(1, "new");



        }
    }
}