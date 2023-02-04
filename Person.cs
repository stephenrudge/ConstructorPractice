using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPractice
{
    public class Person
    {
        public string name { get; set; }
        public string HairColor { get; set; }
        public int Age { get; set; }

        public Person(string taco, string taco1, int taco2)
        {
            name = taco;
            HairColor = taco1;
            Age = taco2;
        }
        public Person()
        {

        } 

    }
}
