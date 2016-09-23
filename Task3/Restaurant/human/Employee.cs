using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
    public class Employee:Human
    {
        private string profession;

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public Employee(string name, string profession):base(name)
        {
            this.profession = profession;
        }

    }
}
