using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OrderApp
{
    public class Order
    {
        public List<OrderDetail> detailList = new List<OrderDetail>();
        public int orderNum;//订单号
        public string consumer;
        public float TotalPrice
        {
            get=>  detailList.Sum(b => b.price);
        }
        
        public Order() { }
        public Order(string conName,int ordNum)
        {
            consumer = conName;
            orderNum = ordNum;
        }
        
        public void AddDetail(OrderDetail orderDe)
        {
            if (detailList.Contains(orderDe))
            {
                throw new ApplicationException($"the goods ({orderDe.goods.name }) have been added!");
            }
            detailList.Add(orderDe);
        }

        public void RemoveDtail(int num)
        {
            detailList.RemoveAt(num);
        }
        public override bool Equals(object obj)
        {
            Order d = obj as Order;
            return d != null && orderNum == d.orderNum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"orderNum is{orderNum}, the consumer is {consumer},the TotalPrice is{TotalPrice}");
            detailList.ForEach(detail => sb.Append("\n\t" + detail));
            return sb.ToString();
        }
    }
}