using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Raynaldo", 20);
            person.GetNameAndAge();
            Console.WriteLine();
            Teacher teacher = new Teacher("Kamarudin", 35, "190302", "Pemrograman");
            teacher.GetNameAndAge();
            Console.WriteLine();
            Student student = new Student("Raynaldo", 20, "19.11.2605", "raynaldo.3003@students.amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}