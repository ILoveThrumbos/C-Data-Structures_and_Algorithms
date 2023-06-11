using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Person
    {
        public string Name;
        public string Email;
        public string TelNum;
        public Address _Address;

        public Person(string _name, string _email, string _telnum)
        {
            Name = _name;
            Email = _email;
            TelNum = _telnum;

        }
        public void setAddress(string _num, string _street, string _suburb, string _postcode, string _state)
        {
            _Address= new Address(_num, _postcode, _state, _street, _suburb);
        }
        public override string ToString()
        {
            return Name + " " + Email + " " + TelNum + _Address;
        }
    }
}
