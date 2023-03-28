using System;
using System.Collections.Generic;

class OrderDetail
{
    public  static List<string> goodList =new List<string>{"A","B","C"};//商品名称
    public static List<int> goodPrice = new List<int> { 10, 20, 30 };//商品单价
    public void display()
    {
        Console.WriteLine("the goods name and its price:");
        foreach(string s in goodList)
        {
            Console.Write(s + "  ");
        }
        Console.WriteLine();
        foreach (int i in goodPrice)
        {
            Console.Write(i + "  ");
        }
        Console.WriteLine();
    }
}
class Order
{
    public static int geneOrderNum = 0;//用于生成订单号
    public List<int> goodsCount = new List<int> { 0, 0, 0 };//订购的三个商品的数目
    public int orderNum;//订单号
    public string consumer;
    public int sum;
    
    public Order(int aNum,int bNum,int cNum,string name)
    {
        goodsCount[0] = aNum;
        goodsCount[1] = bNum;
        goodsCount[2] = cNum;
        consumer = name;
        orderNum = geneOrderNum;
        geneOrderNum++;
        for (int i = 0; i < 3; i++)
        {
            sum += goodsCount[i] * OrderDetail.goodPrice[i];
        }

    }
    /* public void displayOrderDetails()//订单详细
     {
         Console.WriteLine("Your order details are as follows:");
         Console.WriteLine("Your order number is" +orderNum);
         Console.WriteLine(consumer+"  Your order number is" +orderNum);
         for(int i = 0; i < 3; i++)
         {
             Console.WriteLine("you ordered" + goodsCount[i] + Goods.goodList[i] + "which unit price is" + Goods.goodPrice[i]);
         }
         int sum = 0;
         for(int i = 0; i < 3; i++)
         {
             sum += goodsCount[i] * Goods.goodPrice[i];
         }
         Console.WriteLine("the total amount is"+sum);
     }*/
    //重写ToString
    public override string ToString()
    {
        return "--consumer:" + consumer + "--orderNumber:" + orderNum + 
            "--theGoodsNumber:"+goodsCount[0]+","+goodsCount[1]+","+goodsCount[2]+
            "--totaalPrice:" + sum;
    }
    public override bool Equals(object obj)
    {
        Order d = obj as Order;
        return this.orderNum == d.orderNum;
    }
}
class OrderDetails
{
    
}
class OrderService
{
    List<Order> orderList = new List<Order>();//存放订单
    public void addOrder(Order ord)//增加订单
    {
        foreach(Order i in orderList)
        {
            if (ord == i)//如果订单重复发出提示信息
            {
                Console.WriteLine("the order have been added!");
                return;
            }
        }
        orderList.Add(ord);
    }
    public Boolean dropOrder(int ordNum)//通过订单号删除订单
    {
        foreach (Order o in orderList)
        {
            if (o.orderNum == ordNum)
            {
                orderList.Remove(o);
                return true;
            }
        }
        return false;
    }
    public Boolean lookUpOrder(int ordNum)//查询订单
    {
        foreach (Order o in orderList)
        {
            if (o.orderNum == ordNum)
            {
                Console.WriteLine(o);
                return true;
            }
        }
        Console.WriteLine("not matched order!");
        return false;
    }
    public Boolean alterOrder(Order newOrder)//修改订单
    {
        foreach (Order oldOrder in orderList)
        {
            if (oldOrder.orderNum == newOrder.orderNum)
            {
                oldOrder.goodsCount = newOrder.goodsCount;
                oldOrder.consumer = newOrder.consumer;
                return true;
            }
        }
        return false;
    }
    public void display()//输出订单列表
    {
        var query = from s in orderList
                    orderby s.sum descending
                    select s;
        Console.WriteLine("the orders are as follows:");
        foreach(var i in query)
        {
            Console.WriteLine(i.orderNum + "-"+i.sum);
        }
    }
}

class Program
{
    static void Main()
    {
        OrderDetail theDetail = new OrderDetail();
        theDetail.display();
        
        Order myOrder1 = new Order(1, 0, 0, "gaoheng");
        Order myOrder2 = new Order(2, 3, 4, "jack");
        Order myOrder3 = new Order(1, 3, 4, "rose");
        //增加订单
        OrderService myservice = new OrderService();
        myservice.addOrder(myOrder1);
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
        myOrder1.goodsCount[1] = 2;
        myservice.lookUpOrder(myOrder1.orderNum);
        
    }
}