using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassLibrary
{
    public class Student: IPerson
    {
        public string name;
        public string address;
        public DateTime dateOfJoining;


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private DateTime _dateOfJoining;

        public DateTime DateOfJoining
        {
            get { return _dateOfJoining; }
            set { _dateOfJoining = value; }
        }

        public string getInfo()
        {
            return "Name: " + name + ", Address: " + address + ", Date of Joining: " + DateOfJoining.ToString("MM/dd/yyyy");
        }

        public string getTypeOfPerson()
        {
            return "Student";
        }
    }

    

}
