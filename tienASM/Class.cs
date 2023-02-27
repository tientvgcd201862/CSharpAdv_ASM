using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienASM
{
    class Class : IClass
    {
        private string idClass;
        private string nameClass;
        public string IdClass 
        {
            get { return idClass; }
            set { idClass = value; }
        }
        public string NameClass 
        {
            get { return nameClass; }
            set { nameClass = value; }
        }
        public Class()
        {

        }

        public Class(string idClass, string nameClass)
        {
            IdClass = idClass;
            NameClass = nameClass;
        }

        public void ShowClass()
        {
            Console.WriteLine("Id Class: " + IdClass);
            Console.WriteLine("name Class: " + NameClass);
        }
        public void AddClass(List<Class> clas)
        {
            Console.Write("Enter Id Class: ");
            string id = Console.ReadLine();
            Console.Write("Enter name Class: ");
            string name = Console.ReadLine();
            Class cla = new Class(id, name);

            clas.Add(cla);
        }
    }

}
