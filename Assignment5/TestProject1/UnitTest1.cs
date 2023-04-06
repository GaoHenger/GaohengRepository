

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace OrderApp.Tests
{
    [TestClass]
    public class OrderServiceTest
    {
        OrderService myservice = new OrderService();
        Goods goods1 = new Goods("A", 1.3f);
        Goods goods2 = new Goods("B", 2);
        Goods goods3 = new Goods("C", 3);
        Goods goods4 = new Goods("C", 4);
        Goods goods5 = new Goods("C", 5);

        [TestInitialize]
        public void Init()
        {
            
            OrderDetail detail1 = new OrderDetail(goods1, 2);
            OrderDetail detail2 = new OrderDetail(goods2, 3);
            OrderDetail detail3 = new OrderDetail(goods3, 1);
            OrderDetail detail4 = new OrderDetail(goods4, 4);
            OrderDetail detail5 = new OrderDetail(goods5, 5);
            Order myOrder1 = new Order("gaoheng", 1);
            myOrder1.AddDetail(detail1);
            myOrder1.AddDetail(detail2);
            myOrder1.AddDetail(detail3);
            Order myOrder2 = new Order("jack", 2);
            myOrder2.AddDetail(detail3);
            myOrder2.AddDetail(detail4);
            myOrder2.AddDetail(detail5);
            Order myOrder3 = new Order("rose", 3);
            myOrder3.AddDetail(detail1);
            myOrder3.AddDetail(detail4);
            myOrder3.AddDetail(detail5);
            myservice = new OrderService();
            myservice.addOrder(myOrder1);
            myservice.addOrder(myOrder2);
        }
        [TestMethod]
        public void AddOrderTest()
        {
            OrderDetail detail1 = new OrderDetail(goods1, 2);
            OrderDetail detail4 = new OrderDetail(goods4, 4);
            OrderDetail detail5 = new OrderDetail(goods5, 5);
            Order myOrder3 = new Order("rose", 3);
            myOrder3.AddDetail(detail1);
            myOrder3.AddDetail(detail4);
            myOrder3.AddDetail(detail5);
            myservice.addOrder(myOrder3);
            List<Order> orders = myservice.QueryAll();
            Assert.AreEqual(3, orders.Count);
        }
    }
}