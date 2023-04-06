using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
namespace OrderApp
{
    public class OrderService
    {
        List<Order> orderList = new List<Order>();//存放订单
        public void addOrder(Order ord)//增加订单
        {
            if (orderList.Contains(ord))
            {
                throw new ApplicationException($"the order({ord.orderNum}) have been added!");
            }
            orderList.Add(ord);
        }
        public void dropOrder(int num)//通过订单号删除订单
        {
            int index = orderList.FindIndex(o => o.orderNum == num);
            if (index >= 0)
            {
                orderList.RemoveAt(index);
            }
        }
        public void lookUpOrder(int ordNum)//查询订单
        {
            Order temp = orderList.Find(o => o.orderNum == ordNum);
            if (temp == null)
            {
                Console.WriteLine($"the order({ordNum}) is not found!");
            }
            Console.WriteLine(temp);
        }
        public void alterOrder(Order newOrder)//修改订单
        {
            int idx = orderList.FindIndex(o => o.orderNum == newOrder.orderNum);
            if (idx < 0)
            {
                throw new ApplicationException($"the order({newOrder.orderNum}) is not exist!");
            }
            orderList.RemoveAt(idx);
            orderList.Add(newOrder);
        }
        public List<Order> QueryAll()
        {
            return orderList;
        }
        public void display()//输出订单列表
        {
            var query = from s in orderList
                        orderby s.TotalPrice descending
                        select s;
            Console.WriteLine("the orders are as follows:");
            foreach (var i in query)
            {
                Console.WriteLine(i.orderNum + "-" + i.TotalPrice);
            }
        }

    }
}