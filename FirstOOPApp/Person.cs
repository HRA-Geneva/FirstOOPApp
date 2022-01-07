using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPApp
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public bool Gender { get; set; }

        private decimal Salary;


        public string IntroduceYourself()
        {
            string result = "";

            result += "Mənim adım " + Name;
            result += ", mənim soyadım " + Surname;
            result += ", mənim yaşım isə " + Age;

            return result;
        }


    }
}
