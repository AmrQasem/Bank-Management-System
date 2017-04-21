using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Mangement_System
{
    abstract class Person
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public virtual void add() { }
    }
}
