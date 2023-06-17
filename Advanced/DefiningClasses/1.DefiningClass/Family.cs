using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        //public List<Person> People
        //{
        //    get
        //    { 
        //        return this.people;
        //    }
        //    set
        //    { 
        //        this.people = value;
        //    }

        //}
        public Family()
        {
            people =new List<Person>();
        }
        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            return this.people.MaxBy(x => x.Age);
        }

    }
}
