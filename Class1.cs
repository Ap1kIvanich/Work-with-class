using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program

{
    class student
    {
        public string surname;
        public string name;
        public string fathername;
        public int course;
        public int[] grades;
        public double grant;
        public double AvgGrade;



        public student(string surname, string name, string fathername, int course, int[] grades, double grant, double AvgGrade)
        {
            SetValues(surname, name, fathername, course, grades, grant, AvgGrade);
        }
        public student() { }
        public void SetValues(string surname, string name, string fathername, int course, int[] grades, double grant, double AvgGrade)
        {
            this.surname = surname;
            this.name = name;
            this.fathername = fathername;
            this.course = course;
            this.grades = grades;
            this.grant = grant;
            this.AvgGrade = AvgGrade;
        }



        public void print()
        {
            Console.WriteLine($"ФИО: {surname} {name} {fathername}\n Курс: {course}\n Стипендия {grant}\n Средний балл {AvgGrade}");

            Console.WriteLine("Оценки: ");
            foreach (int el in grades)
            {
                Console.Write(el+" ");
            }
        }






    }
}
