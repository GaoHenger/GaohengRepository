using System;
namespace OrderApp
{
    public class Goods
    {
        public string name { get; set; }
        public float price { get; set; }
        public Goods(string s,float p)
        {
            name = s;
            price = p;
        }
        public override string ToString()
        {
            return $"{name}-{price}";
        }
    }
}