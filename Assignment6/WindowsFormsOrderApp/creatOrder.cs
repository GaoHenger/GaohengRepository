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
    public partial class creatOrder : Form
    {
        public creatOrder()
        {
            InitializeComponent();
        }
        public Order myorder = new Order();
        private void SaveOrderDetail_Click(object sender, EventArgs e)
        {
            string goods_name = GoodsName.Text;
            int num = Convert.ToInt32(GoodsQuantity.Text);
     
            switch (goods_name)
            {
                case "milk":
                    myorder.AddDetails(new OrderDetail(new Goods(1,"milk",69.9f), num));
                    break;
                case "apple":
                    myorder.AddDetails(new OrderDetail(new Goods(3, "apple", 5.59f), num));
                    break;
                case "eggs":
                    myorder.AddDetails(new OrderDetail(new Goods(2, "eggs", 4.99f), num));
                    break;
                default:
                    break;
            }
            

            
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            myorder.Id =Convert.ToInt32( OrderId.Text);
            myorder.Customer = customerName.Text;
            Form1.myservice.AddOrder(myorder);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDetailBindingSource.DataSource = myorder.QueryAll();
        }
    }
}
