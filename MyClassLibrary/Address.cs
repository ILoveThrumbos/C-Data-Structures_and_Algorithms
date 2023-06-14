using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{

    public class Address
    {
        public string Num;
        public string Street;
        public string Suburb;
        public string Post_code;
        public string State;

        public Address(string _num, string _street, string _suburb, string _postcode, string _state)
        {
            Num = _num;
            Street = _street;
            Suburb = _suburb;
            Post_code = _postcode;
            State = _state;
        }

        public override string ToString()
        {
            return Num + " " + Street + " " + Suburb + " " + Post_code + " " + State;
        }
    }
}
