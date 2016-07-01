using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int MinValue, MaxValue;
        public bool trs;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generar_Click(object sender, EventArgs e)
        {

            Generator();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Generator()
        {
            try
            {
                Random rn = new Random();
                int Random1 = rn.Next(1, rn.Next(-1000, 2324235));
                int Random2 = rn.Next(rn.Next(9999, 9999999), rn.Next(1004, 578855899)) * Random1;
                if (Random1 > Random2)
                {
                    MinValue = Random2;
                    MaxValue = Random1;
                }
                else
                {
                    MinValue = Random1;
                    MaxValue = Random2;
                }
                long Random3 = rn.Next(MinValue, MaxValue);
                long Random4 = (Random3 * Random2 / Random1 * Random2) * rn.Next(int.MinValue, int.MaxValue);
                long result = Random4;
                textBox1.Text = result.ToString();
            }
            catch
            {
                throw new NotImplementedException();
                trs = true;
            }
            finally
            {
                if (trs==true)
                {
                    this.Close();
                }
             }
        }
    }
}
