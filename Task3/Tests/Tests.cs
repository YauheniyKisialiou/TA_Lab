using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;
using Restaurant.human;

namespace Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Client client = new Client("Flash", 100m, 0.5, false);
            client.MakeOrder();
            Assert.AreEqual(true, client.Order);
        }
    }
}
