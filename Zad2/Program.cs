namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<object> families = new List<object>();
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();              
                for (int j = 0; j < n; j++)
                {
                    person.name = Console.ReadLine();
                    person.age =int.Parse (Console.ReadLine());
                }
                families.Add(person);
            }
            Console.WriteLine(string.Join("\n", families));
        }
    }//ne sme cigani da pravim novi objecti (dqca) sus sushtite imena
}