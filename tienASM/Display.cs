using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienASM
{
    class Display : IDisplay
    {
        public void Menu()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|     Students Management System      |");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|1 : Show Class                       |");
            Console.WriteLine("|2 : Show Student                     |");
            Console.WriteLine("|3 : Add new Class                    |");
            Console.WriteLine("|4 : Add new Student                  |");
            Console.WriteLine("|5 : Update Student                   |");
            Console.WriteLine("|6 : Delete Student                   |");
            Console.WriteLine("|7 : Show Student Of Class            |");
            Console.WriteLine("|8 : Search Student                   |");
            Console.WriteLine("|9 : Exit                             |");
            Console.WriteLine("|                                     |");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("|                                     |");
            Console.WriteLine("---------------------------------------");
        }
    }

}
