using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.Main
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            age = initialAge;
        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 

            var mySwitch = new Dictionary<Func<int, bool>, string>
            {
                 { x => x < 0, "Age is not valid."},
                 { x => x < 13, "You are young."},
                { x => x < 18, "You are a Teenager."},
                { x => x >= 18, "You are old."}
            };

            //mySwitch.First(x => x.Key(age,Report)).Value();

            //var report = mySwitch.First(sw => sw.Key(age)).Value();
            Console.WriteLine(mySwitch.First(sw => sw.Key(age)).Value);
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age++;
        }
    }
}
