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
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void modifyOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void searchOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sortOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sortOrder2Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void showAllOrdersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void showAllOrdersTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}