using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }


        public string FirstLastName => (Firstname + " " + Lastname);
        public string LastFirstName => (Lastname + " " + Firstname);


    }
}
