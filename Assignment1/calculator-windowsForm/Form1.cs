using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_windowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstnum =Convert.ToInt32(textBox1.Text);
            int secondnum =Convert.ToInt32(textBox3.Text);
            char ope = Convert.ToChar(textBox2.Text);
            int result = 0;
            switch (ope)
            {
                case '+':
                    result = firstnum + secondnum;
                    break;
                case '-':
                    result = firstnum - secondnum;
                    break;
                case '*':
                    result = firstnum * secondnum;
                    break;
                case '/':
                    result = firstnum / secondnum;
                    break;
                default:
                    Console.WriteLine("OUT OF RANGE!");
                    break;
            }
            lbHelloWorld.Text = Convert.ToString(result);
        }
    }
}
