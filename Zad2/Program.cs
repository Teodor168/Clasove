namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<Person> families = new List<Person>(); 
           
            for (int i = 0; i < n; i++)
            {
                             Person person = new Person(); 
                
                    person.name = Console.ReadLine();
                    person.age =int.Parse (Console.ReadLine());
                
                families.Add(person);
            }

            for (int i = 0;i < families.Count;i++)
            {
                Console.WriteLine(string.Join(" ", families[i].name, families[i].age));
            }
        }
    }
}