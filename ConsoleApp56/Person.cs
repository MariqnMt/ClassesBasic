using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Person
    {
        // Полета (състояние)
        private string name;
        private int age;

        // Свойство Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Свойство Age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Метод
        public void IntroduceYourself()
        {
            Console.WriteLine($"Здравей! Казвам се {name} и съм на {age} години.");
        }
    }
}
