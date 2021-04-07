using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        OrderService os1 = new OrderService();
        [TestMethod()]
        public void OrderServiceTest()
        {
            new OrderService();
        }

        [TestMethod()]
        public void CreateAOrderTest()
        {
            Guest guest = new Guest("zxy");
            Cargo notebook = new Cargo("notebook", 10.0);
            Dictionary<Cargo, uint> goods1 = new Dictionary<Cargo, uint>();
            goods1.Add(notebook, 2500);
            os1.CreateAOrder(guest, goods1, "Beijing");
        }

        [TestMethod()]
        public void addOrderTest()
        {
            os1.addOrder(new Order());
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            os1.deleteOrder("Guest", "zxy");
        }

        [TestMethod()]
        public void searchOrderTest()
        {
            os1.searchOrder("Guest", "zxy");
        }

        [TestMethod()]
        public void ExportTest1()
        {
            try
            {
                os1.Export("output.xml");
            }
            catch(Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ExportTest2()
        {
            try
            {
                os1.Export("output");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ImportTest1()
        {
            try
            {
                os1.Import("orders.xml");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void ImportTest2()
        {
            try
            {
                os1.Import("output.xml");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        public void ImportTest3()
        {
            try
            {
                os1.Import("output");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}