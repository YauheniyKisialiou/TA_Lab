using Restaurant.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.human
{
    public class Waiter:Employee
    {
        private List<Order> listOfOrder;

        public List<Order> ListofOrder 
        {
            get { return listOfOrder; }
            set { listOfOrder = value; }
        }

        private List<Menu> listofMenu;

        public List<Menu> ListOfMenu
        {
            get { return listofMenu; }
            set { listofMenu = value; }
        }

        public Waiter(string name, string profession, int numberOfMenu) : base(name, profession)
        {
            for (int i = 0; i < numberOfMenu; i++)
            {
                listofMenu = new List<Menu>();
                listofMenu.Add(new Menu($"{i}"));
            }
        }

        public void GetOrder(Order clientOrder)
        {
            listOfOrder = new List<Order>();
            listOfOrder.Add(clientOrder);
        }

        public Menu GiveMenu(int numberOfMenu)
        {
            //for (int i = 0; i < numberOfMenu; i++)
            //{
            //    Menu tempMenu = listofMenu[i];
            //    listofMenu.Remove(null);
            //}
            Menu tempMenu = listofMenu[0];
            listofMenu.Remove(null);
            return tempMenu;
        }

        public Order GiveOrder()
        {
            Order tempOrder = listOfOrder[0];
            listOfOrder.Remove(null);
            return tempOrder;
        }


    }
}
