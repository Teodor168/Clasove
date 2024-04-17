namespace RabotaVklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semeistvo myFamily = new Semeistvo();
            myFamily.FamilyName = "Ilievi";
            Console.Write("kolko choveka e familiqta: ");
            int count = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"vavedi {i + 1} chovek: ");
                Person current = new Person();
                Console.Write($"vavedi ime na {i + 1} chovek: ");
                current.Name = Console.ReadLine();
                Console.Write($"vavedi godini na {i + 1} chovek: ");
                current.Age = int.Parse(Console.ReadLine());
                myFamily.Members.Add(current);
            }

            //bubble sort
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (myFamily.Members[j].Age > myFamily.Members[j + 1].Age)
                    {
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j] = myFamily.Members[j + 1];
                        myFamily.Members[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            //a) 
            //sndfsiafdnp


            //b)
            //foreach (Person member in myFamily.Members)
            //{
            //    total += member.Age; 
            //}

            int sum = myFamily.SumOfTheFamily();

           
            
         
            //Pechat
            myFamily.PrintAll();
            Console.WriteLine();
            myFamily.PrintYoungest();
            Console.WriteLine();
            myFamily.PrintOldest();
            Console.WriteLine($"Sumata e ot godinite e: {sum}");
        }
    }
}