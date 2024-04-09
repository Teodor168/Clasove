using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Zad1
{
    public class Person
    {
        public string name;         
        public int age; 
        public void Eat()
        {
            Console.WriteLine(this.name + " nqm, nqm vkusno");
        }
    }
}