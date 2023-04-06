using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OrderApp
{
    public class OrderDetail
    {
        public Goods goods { get; set; }
        public int quantity { get; set; }//商品数目
        public float price
        {
            get => goods.price * quantity;
        }

        public OrderDetail() { }
        public OrderDetail(Goods g,int num)
        {
            goods = g;
            quantity = num;
        }
        public OrderDetail changeDetail(Goods g,int num)
        {
            if (g == null || num < 0)
            {
                Console.WriteLine("the details change error");
            }
            goods = g;
            quantity = num;
            return this;
        }
        public override string ToString()
        {
            return $"the order detail:{goods},{quantity}";
        }
    }
}