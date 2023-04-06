using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
        }
        public string condition { get; set; }
        public static OrderService myservice = new OrderService();
        
        private void QueryButton_Click(object sender, EventArgs e)
        {
            /*Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1, new DateTime(2021, 3, 21));
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));

            Order order2 = new Order(2, customer2, new DateTime(2021, 3, 21));
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2, new DateTime(2021, 3, 21));
            order3.AddDetails(new OrderDetail(milk, 100));

            myservice.AddOrder(order1);
            myservice.AddOrder(order2);
            myservice.AddOrder(order3);*/

            //****************************************
            if (comboBox1.SelectedItem == null)
            {
                orderBindingSource1.DataSource = myservice.QueryAll();
            }
            else
            {
                condition = comboBox1.SelectedItem.ToString();
            }
            
            if (condition == "订单号")
            {
                int OrderId = Convert.ToInt32(textBox1.Text);
                orderBindingSource1.DataSource = myservice.GetById(OrderId);
            }else if(condition == "客户名")
            {
                orderBindingSource1.DataSource = myservice.QueryByCustomerName(textBox1.Text);
            }
            else if (condition == "货物名")
            {
                orderBindingSource1.DataSource = myservice.QueryByGoodsName(textBox1.Text);
            }
            else if (condition == "总价格")
            {
                int totalPrice = Convert.ToInt32(textBox1.Text);
                orderBindingSource1.DataSource = myservice.QueryByTotalPrice(totalPrice);
            }
            else
            {
                orderBindingSource1.DataSource = myservice.QueryAll();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            creatOrder form2 = new creatOrder();
            form2.Show();
        }
    }
}
