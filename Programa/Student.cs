using System;
using System.Collections.Generic;
using System.Text;

namespace Programa
{
    public class Student
    {
        //variables glovales
        public string name;
        public int year;
        public double grade;

        public Student()
        {
            name = "";
            year = 1900;
            grade = 0;
        }

        public Student(string name,int year, double grade)
        {
            //variable locales
            this.name = name;
            this.year = year;
            this.grade = grade;
        }
    }   
}
