using InterfaceClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {



            Teacher teacher = new Teacher();
            teacher.name = "Tharun";
            teacher.address = "12/46/2";
            
            teacher.DateOfJoining =  DateTime.Today;

            Student student = new Student();

            student.name = "Kumar";
            student.address = "24/12/2";
            student.DateOfJoining = DateTime.Today;


            OfficeStaff staff = new OfficeStaff();

            staff.name = "Venkat";
            staff.address = "12/46/6";
            staff.DateOfJoining = DateTime.Today;



            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());

            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());

            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
            Console.ReadLine(); 


        }
    }
}
