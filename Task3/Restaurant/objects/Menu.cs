using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.objects
{
    public class Menu
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Menu(string name)
        {
            this.name = name;
        }

    }
}
