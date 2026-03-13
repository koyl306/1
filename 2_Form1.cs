using System;
using System.Windows.Forms;

namespace pract1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //litres
            double gotlitres = 0;
            
            //if (string.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("Скіки залили????");
            //    textBox1.Focus();
            //}else
            //    gotlitres = double.Parse(textBox1.Text);

            gotlitres = Convert.ToDouble(numericUpDown1.Value);

            //gas type
            double price = 0;

            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Який бензин?????");
                    break;

                case 0:
                    //92
                    price = 63.78;
                    break;
                
                case 1:
                    //95
                    price = 67.2;
                    break;

                case 2:
                    //98
                    price = 71.67;
                    break;
                
                default:
                    price = 1;
                    break;
            }

            //discount
            string discountText = textBox2.Text;
            bool discountValid = false;
            if (discountText == "FF35")
                discountValid = true;

            //calc(short from calculator chat)
            double fullprice=0;
            if (gotlitres>0 && price > 0)
            {
                fullprice = gotlitres * price;
                if (discountValid)
                    fullprice = fullprice * 0.35;
            }

            //new
            double hotdogprice = 40, coffeprice = 20, gumprice = 5, puppydisc = 50;
            int hotdogamount = Convert.ToInt32(numericUpDown2.Value),
                coffeamount = Convert.ToInt32(numericUpDown3.Value),
                gumamount = Convert.ToInt32(numericUpDown4.Value);
            bool puppy = checkBox1.Checked;

            double priceandlots = 0;
            priceandlots = fullprice +
                hotdogamount * hotdogprice +
                coffeamount * coffeprice +
                gumamount * gumprice;

            if (puppy)
                priceandlots = priceandlots * 0.5;
            
            textBox3.Text = Convert.ToString(priceandlots);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tabControl1.TabPages)
            {
                comboBox1.SelectedIndex = -1;
                textBox2.Text = "";
                textBox3.Text = "";

                foreach (Control c in page.Controls) //gpt
                {
                    if (c is NumericUpDown n)
                        n.Value = 0;
                }
            }
        }
    }
}
