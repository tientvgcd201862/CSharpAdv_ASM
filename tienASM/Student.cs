using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace tienASM
{
    class Student : IStudent
    {
        private string idStudent;
        private string firstName;
        private string lastName;
        private string numberPhone;
        private string email;
        private string idcl;
        public string IdStudent 
        {   get { return idStudent; } 
            set { idStudent = value; } 
        }
        public string FristName 
        {
            get {return firstName; }
            set { firstName = value; } 
        }
        public string LastName 
        {
            get { return lastName; }
            set { lastName = value; } 
        }
        public string NumberPhone 
        {
            get { return numberPhone; }
            set { numberPhone = value; }
        }
        public string Email 
        {
            get { return email; }
            set { email = value; } 
        }
        public string Idcl 
        {
            get { return idcl; }
            set { idcl = value; }
        }


        public Student()
        {
        }

        public Student(string idStudent, string fristName, string lastName, string numberPhone, string email, string idcl)
        {
            IdStudent = idStudent;
            FristName = fristName;
            LastName = lastName;
            NumberPhone = numberPhone;
            Email = email;
            Idcl = idcl;
        }

        public void ShowStudent()
        {
            Console.WriteLine("Id Student: " + IdStudent);
            Console.WriteLine("name student: " + LastName + " " + FristName);
            Console.WriteLine("NumberPhone: " + NumberPhone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Id class: " + Idcl);
        }

        public void AddStudent(List<Student> students, List<Class> clas)
        {
            Console.Write("Enter Id student: ");
            string ids = Console.ReadLine();
            Console.Write("Enter Frist name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter Last name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter Phone Number : ");
            string phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Id Class: ");
            string idcl = Console.ReadLine();

            int i = 0;
            foreach (Class c in clas)
            {
                if (String.Compare(idcl, c.IdClass, true) == 0)
                {
                    i++;
                }
            }

            if (i != 0)
            {
                Student st = new Student(ids, fname, lname, phone, email, idcl);

                students.Add(st);
            }
        }
        public void UpdateStudent(List<Student> students, List<Class> clas)
        {
            Console.Write("Enter Id Student Update: ");
            string idst1 = Console.ReadLine();


            Console.Write("Enter Frist Name: ");
            string fname1 = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lname1 = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            string phone1 = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email1 = Console.ReadLine();
            Console.Write("Enter Id Class: ");
            string idcl1 = Console.ReadLine();

            int j = 0;
            foreach (Class c in clas)
            {
                if (String.Compare(idcl1, c.IdClass, true) == 0)
                {
                    j++;
                }
            }

            if (j != 0)
            {
                var itemToUpdate = students.FirstOrDefault(r => r.IdStudent == idst1);
                itemToUpdate.FristName = fname1;
                itemToUpdate.LastName = lname1;
                itemToUpdate.NumberPhone = phone1;
                itemToUpdate.Email = email1;
                itemToUpdate.Idcl = idcl1;
            }
        }
        public void DeleteStudent(List<Student> students)
        {
            Console.Write("Enter Id Student Delete: ");
            string idst = Console.ReadLine();

            var itemToRemove = students.SingleOrDefault(r => r.IdStudent == idst);
            if (itemToRemove != null)
                students.Remove(itemToRemove);
        }
        public void ShowStudentOfClass(List<Student> students)
        {
            Console.Write("Enter Id Class: ");
            string idcl2 = Console.ReadLine();

            foreach (Student s in students)
            {
                if (String.Compare(idcl2, s.Idcl, true) == 0)
                {
                    s.ShowStudent();
                }
            }
        }
        public void SearchStudentById(List<Student> students)
        {
            Console.Write("Enter Id Student: ");
            string idst2 = Console.ReadLine();

            Student item = students.SingleOrDefault(r => r.IdStudent == idst2);
            if (item != null)
                item.ShowStudent();
        }
    }
}



