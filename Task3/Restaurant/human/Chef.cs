using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
    class Chef:Employee
    {
        private List<Order> listOfOrder;
        private bool orderStatus;

        public bool OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }


        public List<Order> ListofOrder
        {
            get { return listOfOrder; }
            set { listOfOrder = value; }
        }

        public Chef(string name, string profession) : base(name, profession)
        {
           
        }

        public void GetOrder(Order waiterOrder)
        {
            listOfOrder = new List<Order>();
            listOfOrder.Add(waiterOrder);
        }

        public Order GiveOrder()
        {
            Order tempOrder = listOfOrder[0];
            listOfOrder.Remove(null);
            return tempOrder;
        }

        public void Cook()
        {
            orderStatus = true;
        }



    }
}
