using Classes.Lesson.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Lesson.Code
{
    internal class Bank
    {
        public Person Person { get; set; }  // Property pubblica
        public Bank(Person person) // Costruttore 
        {
            Person = person;
            Person._name = "Marco";
        }
    }
}
