using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotaVklas
{
    public class Semeistvo
    {
        private string familyName;
        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach (Person item in this.Members)
            {
                item.Intruduce();
            }
        }
        public void PrintYoungest()
        {
            int minAge=int.MaxValue;
            Person younger=new Person();
            foreach (Person item in this.Members)
            {
                if(item.Age < minAge)
                {
                    item.Age = minAge;
                    younger= item;
                }
            }
            younger.Intruduce();

        }
        public void PrintOldest()
        {
            int minAge=0;
            Person oldest=new Person();
            foreach (Person item in this.Members)
            {
                if (item.Age > minAge)
                {
                    minAge = item.Age;
                    oldest= item;
                }
            }
            oldest.Intruduce();
        }

        public int SumOfTheFamily()
        {
            int sum=0;
            foreach (Person item in this.Members)
            {
                sum=sum+item.Age;
            }
            return sum;
        }
    }
}
