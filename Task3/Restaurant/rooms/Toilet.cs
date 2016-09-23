using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Rooms
{
    class Toilet
    {
        private bool busy;
        private bool toiletPaper;

        public bool ToiletPaper
        {
            get { return toiletPaper; }
            set { toiletPaper = value; }
        }

        public bool Busy
        {
            get { return busy; }
            set { busy = value; }
        }

    }
}
