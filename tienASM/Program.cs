using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace tienASM
{
    class Program
    {
        public static List<Student> students { get; internal set; }
        public static List<Class> clas { get; internal set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Students Management System by tiengcd201862");

            clas = new List<Class>();
            students = new List<Student>();

            Display display = new Display();
            display.Menu();

            Student student = new Student();
            Class cls = new Class();
            Console.Write("Enter your choice: ");            
            Console.WriteLine("");

            int choice = 0;
            do
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                
                switch (choice)
                {
                    case 1:
                        foreach (Class c in clas)
                        {
                            c.ShowClass();
                        }
                        display.Menu();
                        break;
                    case 2:
                        foreach (Student s in students)
                        {
                            s.ShowStudent();
                        }
                        display.Menu();
                        break;
                    case 3:
                        cls.AddClass(clas);
                        display.Menu();
                        break;
                    case 4:
                        student.AddStudent(students,clas);
                        display.Menu();
                        break;
                    case 5:
                        student.UpdateStudent(students, clas);
                        display.Menu();
                        break;
                    case 6:
                        student.DeleteStudent(students);
                        display.Menu();
                        break;
                    case 7:
                        student.ShowStudentOfClass(students);
                        display.Menu();
                        break;
                    case 8:
                        student.SearchStudentById(students);
                        display.Menu();
                        break;
                }
            } while (choice != 9);
        }
    }
}



