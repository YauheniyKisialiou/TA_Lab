
using Restaurant.interfaces;
using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
     public class Client:Human, IEat , IDoOrder
    {
        private bool order;
        private bool menu;
        private decimal money;
        private double hunger;
        private Menu clientMenu;
        private Order clientOrder;

        public Order ClientOrder
        {
            get { return clientOrder; }
            set { clientOrder = value; }
        }


        public bool Menu
        {
            get { return menu; }
            set { menu = value; }
        }


        public Menu ClientMenu
        {
            get { return clientMenu; }
            set { clientMenu = value; }
        }


        public decimal Money
        {
            get { return money; }
            set { money = value; }
        }


        public double Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }


        public bool Order
        {
            get { return order; }
            set { order = value; }
        }
        public Client(string name, decimal money, double hunger, bool order):base(name)
        {
            this.money = money;
            this.hunger = hunger;
            this.order = order;
        }

        public void Eat()
        {
            hunger = 0.7;
        }

        public void MakeOrder()
        {
            order = true;
            clientOrder = new Order();
        }

        public void TakeMenu(Menu menu)
        {
            clientMenu = menu;
            this.menu = true;
        }

        public void GetReadyOrder(Order readeOrder)
        {
            clientOrder = readeOrder;
        }

    }
}
