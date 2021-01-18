using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Task3OOP
{
    class Person
    {
        public string name;
        protected int id;

        public Person(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get {return id; }
            set {id = value; }
        }
    }
}
