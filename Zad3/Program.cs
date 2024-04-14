namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<Person> families = new List<Person>();
            List<string> imena = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Person person = new Person();

                person.name = Console.ReadLine();
                person.age = int.Parse(Console.ReadLine());
                imena.Add(person.name);
                families.Add(person);
            }

           imena.Sort();
            for (int i = 0; i < families.Count; i++)
            {
                if (families[i].age >= 30)
                {               
                Console.WriteLine(string.Join(" ", imena[i], families[i].age));
                }                
            }
        }
    }
}