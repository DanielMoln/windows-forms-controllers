using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Person
    {
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {BirthDate}";
        }
    }
}
