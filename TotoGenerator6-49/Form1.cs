using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotoGenerator6_49
{
    public partial class Form1 : Form
    {

        Random numGen = new Random();
        int val = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using it!\n\nby Kaloyan Zahariev! \n \n v. 1.0", "About this program");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateNumbers();
        }

        private void generateNumbers()
        {
            val = numGen.Next(1, 50);
            num1.Text = val.ToString();

            val = numGen.Next(1, 50);
            while (val.ToString().Equals(num1.Text))
            {
                val = numGen.Next(1, 50); 
            }
            num2.Text = val.ToString();

            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text))
            {
                val = numGen.Next(1, 50);
            }
            num3.Text = val.ToString();

            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text) || val.ToString().Equals(num3.Text))
            {
                val = numGen.Next(1, 50);
            }
            num4.Text = val.ToString();


            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text) || val.ToString().Equals(num3.Text) || val.ToString().Equals(num4.Text))
            {
                val = numGen.Next(1, 50);
            }
            num5.Text = val.ToString();

            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text) || val.ToString().Equals(num3.Text) || val.ToString().Equals(num4.Text) || val.ToString().Equals(num5.Text))
            {
                val = numGen.Next(1, 50);
            }
            num6.Text = val.ToString();
        }
    }
}
