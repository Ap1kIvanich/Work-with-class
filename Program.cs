using System;
using System.Security.Cryptography;
using System.Timers;
using System.Xml.Linq;
using System.Linq;

namespace program
{


    class Program
    {

        static void Main()
        {
            string surname;
            string name;
            string fathername;
            int course;
            int[] grades;
            double grant, AvgGrade;
            string path = @"D:\VisualStudio\HomeTasks\file.txt";


            student student_1 = new student();
            InputStudentInfo(out string surname1, out string name1, out string fathername1, out int course1, out int[] grades1, out double grant1, out double AvgGrade1, out bool GettingGrant1);
            student_1.SetValues(surname1, name1, fathername1, course1, grades1, grant1, AvgGrade1);
            student_1.print();

            Console.WriteLine("\n");

            student student_2 = new student();
            InputStudentInfo(out string surname2, out string name2, out string fathername2, out int course2, out int[] grades2, out double grant2, out double AvgGrade2, out bool GettingGrant2);
            student_2.SetValues(surname2, name2, fathername2, course2, grades2, grant2, AvgGrade2);
            student_2.print();

            Console.WriteLine("\n");

            student student_3 = new student();
            InputStudentInfo(out string surname3, out string name3, out string fathername3, out int course3, out int[] grades3, out double grant3, out double AvgGrade3, out bool GettingGrant3);
            student_3.SetValues(surname3, name3, fathername3, course3, grades3, grant3, AvgGrade3);
            student_3.print();


            string content1 = $"ФИО: {surname1} {name1} {fathername1}\n Курс: {course1} Стипендия {grant1} Средний балл {AvgGrade1} getting grant is {GettingGrant1}\n\n";
            string content2 = $"ФИО: {surname2} {name2} {fathername2}\n Курс: {course2} Стипендия {grant2} Средний балл {AvgGrade2} getting grant is {GettingGrant2}\n\n";
            string content3 = $"ФИО: {surname3} {name3} {fathername3}\n Курс: {course3} Стипендия {grant3} Средний балл {AvgGrade3} getting grant is {GettingGrant3}";

            string contents = content1 + content2 + content3;
            AppendAllText(path,contents);
            


        }

        public static void InputStudentInfo(out string surname, out string name, out string fathername, out int course, out int[] grades, out double grant, out double AvgGrade, out bool GettingGrant)
        {
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();

            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите отчество: ");
            fathername = Console.ReadLine();

            Console.Write("Введите курс: ");
            course = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во оценок: ");
            int n = int.Parse(Console.ReadLine());

            grades = new int[n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Оценка {count}: ");
                grades[i] = Convert.ToInt16(Console.ReadLine());
                count++;
            }

            Console.Write("Введите стипендию: ");
            grant = Convert.ToDouble(Console.ReadLine());

            int summ = 0;
            for (int j = 0; j < grades.Length; j++)
                summ += grades[j];
            AvgGrade = summ / grades.Length;

            
            if (grades.Contains(2) || grades.Contains(3)) 
            {
                GettingGrant = false;
            }
            else
            {
                GettingGrant = true;
            }
        }

        public static void AppendAllText(string path, string? contents)
        {
            path = @"D:\VisualStudio\HomeTasks\file.txt";
            File.AppendAllText(path, contents);
        }
    }
}