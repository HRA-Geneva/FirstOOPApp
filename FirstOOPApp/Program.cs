using System;

namespace FirstOOPApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Terlan";

            Person person1 = new Person();

            person1.Name = "Terlan";
            person1.Surname = "Usubov";
            person1.Age = 22;


            string introduce = person1.IntroduceYourself();

            Console.WriteLine(introduce);
        }
    }
}
