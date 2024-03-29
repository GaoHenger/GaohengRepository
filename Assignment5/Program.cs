﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class Program
    {
        static void Main()
        {
            Goods goods1 = new Goods("A", 1.3f);
            Goods goods2 = new Goods("B", 2);
            Goods goods3 = new Goods("C", 3);
            Goods goods4 = new Goods("C", 4);
            Goods goods5 = new Goods("C", 5);
            Console.WriteLine(goods1);
            OrderDetail detail1 = new OrderDetail(goods1, 2);
            OrderDetail detail2 = new OrderDetail(goods2, 3);
            OrderDetail detail3 = new OrderDetail(goods3, 1);
            OrderDetail detail4 = new OrderDetail(goods4, 4);
            OrderDetail detail5 = new OrderDetail(goods5, 5);
            Console.WriteLine(detail1);
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
            Console.WriteLine(myOrder1);
            //增加订单
            OrderService myservice = new OrderService();
            myservice.addOrder(myOrder1);
            myservice.addOrder(myOrder2);
            myservice.addOrder(myOrder3);
            myservice.display();
            //删除订单
            myservice.dropOrder(myOrder2.orderNum);
            myservice.display();
            //查询订单
            myservice.lookUpOrder(myOrder1.orderNum);
            myservice.lookUpOrder(myOrder2.orderNum);
            //修改订单
           
            myOrder1.RemoveDtail(1);
            myservice.alterOrder(myOrder1);
            myservice.lookUpOrder(myOrder1.orderNum);

        }
    }
}