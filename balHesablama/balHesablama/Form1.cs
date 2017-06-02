using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balHesablama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "0";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result.fennNeticeleri(int.Parse(textBox1.Text), int.Parse(textBox2.Text), 4);
            result.fennNeticeleri(int.Parse(textBox3.Text), int.Parse(textBox4.Text), 4);
            result.fennNeticeleri(int.Parse(textBox5.Text), int.Parse(textBox6.Text), 4);
            result.fennNeticeleri(int.Parse(textBox7.Text), int.Parse(textBox8.Text), 8);
            result.fennNeticeleri(int.Parse(textBox9.Text), int.Parse(textBox10.Text), 8);
            textBox11.Text = result.calculate().ToString();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Clear();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox11.Text) <= 0){
                Console.WriteLine("Siz imtahandan kəsildiniz.");
            }
        }
    }
}
