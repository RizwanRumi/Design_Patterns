using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternConsole
{
    class Program
    {
        /// <summary>
        /// Structural Design Pattern
        /// </summary>
        /// <param name="args">Filter Pattern</param>
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            Criteria male = new CriteriaMale();
            Criteria female = new CriteriaFemale();
            Criteria single = new CriteriaSingle();
            Criteria singleMale = new AndCriteria(single, male);
            Criteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            printPersons(male.MeetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            printPersons(female.MeetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            printPersons(singleMale.MeetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            printPersons(singleOrFemale.MeetCriteria(persons));

            Console.ReadLine();
        }

        public static void printPersons(List<Person> persons)
        {

            foreach(var person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.GetName() + ", Gender : " + person.GetGender() + ", Marital Status : " + person.GetMaritalStatus() + " ]");
            }
        }
    }
}
