using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem__number_2
{
    class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public virtual string getName()
        {
            return name;
        }

        public virtual string getAddress()
        {
            return this.address;
        }

        public virtual void setAdress(string address)
        {
            this.address = address;
        }

        public override string ToString()
        {
            return $"Name = {getName()} Address = {getAddress()}";
        }
    }
}
