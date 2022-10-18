using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_XL
{
    internal class Person
    {
        private string name;
        private int ssn;
        private string gender;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Ssn { get { return ssn; } set { ssn = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(string name, int ssn, string gender, int age)
        {
            this.name = name;
            this.ssn = ssn;
            this.gender = gender;
            this.age = age;
        }

        public override string ToString()
        {
            return name + " " + ssn + " " + gender + " " + age;
        }
    }
}
