using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _1_2lab
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        ArrayList objectList = new ArrayList();
        private void Button7_Click_1(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(textBox4.Text);
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                objectList.Add(rand.Next(-10, 10));
            }

            string str = "";
            foreach (object o in objectList)
            {
                str += o.ToString();
                str += " ";
            }
            textBox5.Text = str;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            objectList.Sort();
            string str = "";
            foreach (object o in objectList)
            {
                str += o.ToString();
                str += " ";
            }
            textBox6.Text = str;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            objectList.Sort();
            objectList.Reverse();
            string str = "";
            foreach (object o in objectList)
            {
                str += o.ToString();
                str += " ";
            }
            textBox6.Text = str;
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            var rezult = from int p in objectList
                         orderby p
                         select p;

            textBox6.Text = rezult.Last().ToString();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var rezult = from int p in objectList
                         orderby p
                         select p;

            textBox6.Text = rezult.First().ToString();
        }

        private void Button12_Click_1(object sender, EventArgs e)
        {
            var rezult = from int p in objectList
                         where p < 0
                         select p;
            string str = "";
            foreach (object o in rezult)
            {
                str += o.ToString();
                str += " ";
            }
            textBox6.Text = str;
        }

       
    }
}
