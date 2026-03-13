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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back); //шоб тільки цифри, взято зі стаксоверфлоу. змінила, тепер шоб тільки цифри крапка і бекспейс
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //litres
            double gotlitres = 0;
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Скіки залили????");
                textBox1.Focus();
            }else
                gotlitres = double.Parse(textBox1.Text);

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
            
            textBox3.Text = Convert.ToString(fullprice);
        }
    }
}
