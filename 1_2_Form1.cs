using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) ||  e.KeyChar == (char)Keys.Back); //взято зі стаксоверфлоу
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //name and surname
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введіть ім'я");
                textBox1.Focus();
                return;
            }
            string name = Convert.ToString(char.ToUpper(textBox1.Text[0]) + textBox1.Text.Substring(1));

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Введіть прізвище");
                textBox2.Focus();
                return;
            }
            string surname = Convert.ToString(char.ToUpper(textBox2.Text[0]) + textBox2.Text.Substring(1));

            //year
            int year =0;
            int tb4=0;
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Введіть рік народження");
                textBox3.Focus();
                return;
            } else
                tb4 = Convert.ToInt32(textBox3.Text);

            if (tb4<=2012 && tb4>=1900)
                year = tb4;
            else
            {
                MessageBox.Show("Введіть СПРАВЖНІЙ рік народження");
                textBox3.Focus();
                return;
            }

            //group
            string group = "";
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Введіть групу");
                textBox4.Focus();
                return;
            }
            group = textBox4.Text;

            //course
            int course = 0;
            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Оберіть курс");
                    return;
                    break;

                case 0:
                    course = 1;
                    break;

                case 1:
                    course = 2;
                    break;

                case 2:
                    course = 3;
                    break;

                case 3:
                    course = 4;
                    break;

                case 4:
                    course = 5;
                    break;
            }

            listBox1.Items.Add(name);
            listBox1.Items.Add(surname);
            listBox1.Items.Add(year);
            listBox1.Items.Add("група " + group);
            listBox1.Items.Add(course + " курс");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
