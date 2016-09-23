using Restaurant.human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Flash", 100m , 0.5 , false);
            Waiter waiter = new Waiter("BatMan", "waiter", 2);
            Chef chef = new Chef("WonderWoman", "chef");

            if (client.Menu)
            {
                Console.WriteLine("client has menu");
            }
            else
            {
                Console.WriteLine("no menu");
            }

            client.TakeMenu(waiter.GiveMenu(1));
            client.MakeOrder();
            waiter.GetOrder(client.ClientOrder);
            chef.GetOrder(waiter.GiveOrder());
            chef.Cook();

            if (chef.OrderStatus)
            {
                Console.WriteLine("Reade!");
                waiter.GetOrder(chef.GiveOrder());
            }
            else
            {
                Console.WriteLine("not reade yet");
            }
            client.GetReadyOrder(waiter.GiveOrder());
            client.Eat();
            if (client.Hunger == 1)
            {
                Console.WriteLine($"{client.Name} is saying \"I am full\"");
            }
            else
            {
                Console.WriteLine($"{client.Name} is saying \"I am hungry\"");
            }
            
            if (client.Menu)
            {
                Console.WriteLine("client has menu");
            }
            else
            {
                Console.WriteLine("no menu");
            }
            Console.ReadLine();

            
        }

        //public bool IsOrderReade(bool orderStatus)
        //{
        //    return orderStatus ? true : false;
        //}

    }
}
