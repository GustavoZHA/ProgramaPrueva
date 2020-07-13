using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1= new Student();
            student1.name = "jose";
            student1.grade = 72.5;
            student1.year = 2020;

            Console.WriteLine(student1.name);

            Student student2 = new Student("Gustavo Huanca", 2020, 95);
            student2.name = "Gustavo H.";
            Console.WriteLine(student2.name);
            
        }
    }
}
