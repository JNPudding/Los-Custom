using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Los_Custom___Tunagem
{
    public partial class Painel : Form
    {
        private Dictionary<String, int> priceList; 
        public Painel()
        {
            InitializeComponent();

            this.priceList = new Dictionary<string, int>();

            // Desempenhos
            priceList.Add("checkBox1", 70000);
            priceList.Add("checkBox2", 30000);
            priceList.Add("checkBox3", 60000);
            priceList.Add("checkBox4", 50000);
            priceList.Add("checkBox5", 50000);

            // Blindagem (kevlar)
            priceList.Add("checkBox6", 150000);
            priceList.Add("checkBox7", 30000);

            // Tunagem
            priceList.Add("checkBox8", 260000); // Tunagem Full
            priceList.Add("checkBox9", 410000);
            priceList.Add("checkBox10", 290000);
            priceList.Add("checkBox11", 440000); // Tunagem + Blindagem Full

            // Pintura
            priceList.Add("checkBox12", 4000);
            priceList.Add("checkBox13", 3000);
            priceList.Add("checkBox14", 8000);
            priceList.Add("checkBox15", 10000);

            // Estética
            priceList.Add("checkBox16", 15000);
            priceList.Add("checkBox17", 15000);
            priceList.Add("checkBox18", 15000);
            priceList.Add("checkBox19", 15000);
            priceList.Add("checkBox20", 15000);
            priceList.Add("checkBox21", 15000);
            priceList.Add("checkBox22", 15000);
            priceList.Add("checkBox23", 15000);
            priceList.Add("checkBox24", 40000);
            priceList.Add("checkBox25", 3000);

            // Interior
            priceList.Add("checkBox26", 70000);
            priceList.Add("checkBox27", 85000);
            priceList.Add("checkBox28", 15000);
            priceList.Add("checkBox29", 15000);
            priceList.Add("checkBox30", 25000);
            priceList.Add("checkBox31", 10000);
            priceList.Add("checkBox32", 25000);
            priceList.Add("checkBox33", 25000);
            priceList.Add("checkBox34", 20000);
            priceList.Add("checkBox35", 25000);
            priceList.Add("checkBox36", 25000);
            priceList.Add("checkBox37", 25000);
            priceList.Add("checkBox38", 25000);
            priceList.Add("checkBox39", 10000);
            priceList.Add("checkBox40", 15000);
            priceList.Add("checkBox41", 10000);
            priceList.Add("checkBox42", 10000);
            priceList.Add("checkBox43", 3000);
            priceList.Add("checkBox44", 1000);
            priceList.Add("checkBox45", 10000);
            priceList.Add("checkBox46", 15000);
            priceList.Add("checkBox47", 5000);
            priceList.Add("checkBox48", 5000);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            updateCost(priceList[checkbox.Name], checkbox.Checked);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int totalVal = int.Parse(this.textBox1.Text);
                this.textBox2.Text = (totalVal * 0.1).ToString();
                this.textBox3.Text = (totalVal * 0.05).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void updateCost(int newItemPrice, bool option)
        {
            try
            {
                int totalVal = int.Parse(this.textBox1.Text);

                if (option)
                {
                    totalVal += newItemPrice;
                }
                else
                {
                    totalVal -= newItemPrice;
                }

                this.textBox1.Text = totalVal.ToString();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control cBox in this.Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            updateCost(priceList[checkbox.Name], checkbox.Checked);
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            updateCost(priceList[checkbox.Name], checkbox.Checked);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
 
        }
    }
}
