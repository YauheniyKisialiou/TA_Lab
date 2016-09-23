using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
    public class Human
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Human(string name)
        {
            this.name = name;
        }

    }
}
