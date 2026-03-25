using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pract3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    listBox1.Items.Clear();

        //    //name and surname
        //    if (string.IsNullOrEmpty(textBox1.Text))
        //    {
        //        MessageBox.Show("Введіть ім'я");
        //        textBox1.Focus();
        //        return;
        //    }
        //    string name = Convert.ToString(char.ToUpper(textBox1.Text[0]) + textBox1.Text.Substring(1));

        //    if (string.IsNullOrEmpty(textBox2.Text))
        //    {
        //        MessageBox.Show("Введіть прізвище");
        //        textBox2.Focus();
        //        return;
        //    }
        //    string surname = Convert.ToString(char.ToUpper(textBox2.Text[0]) + textBox2.Text.Substring(1));

        //    //year
        //    int year = 0;
        //    int tb4 = 0;
        //    if (string.IsNullOrEmpty(textBox3.Text))
        //    {
        //        MessageBox.Show("Введіть рік народження");
        //        textBox3.Focus();
        //        return;
        //    }
        //    else
        //        tb4 = Convert.ToInt32(textBox3.Text);

        //    if (tb4 <= 2012 && tb4 >= 1900)
        //        year = tb4;
        //    else
        //    {
        //        MessageBox.Show("Введіть СПРАВЖНІЙ рік народження");
        //        textBox3.Focus();
        //        return;
        //    }

        //    //group
        //    string group = "";
        //    if (string.IsNullOrEmpty(textBox4.Text))
        //    {
        //        MessageBox.Show("Введіть групу");
        //        textBox4.Focus();
        //        return;
        //    }
        //    group = textBox4.Text;

        //    //course
        //    int course = 0;
        //    switch (comboBox1.SelectedIndex)
        //    {
        //        case -1:
        //            MessageBox.Show("Оберіть курс");
        //            return;
        //            break;

        //        case 0:
        //            course = 1;
        //            break;

        //        case 1:
        //            course = 2;
        //            break;

        //        case 2:
        //            course = 3;
        //            break;

        //        case 3:
        //            course = 4;
        //            break;

        //        case 4:
        //            course = 5;
        //            break;
        //    }

        //    listBox1.Items.Add(name);
        //    listBox1.Items.Add(surname);
        //    listBox1.Items.Add(year);
        //    listBox1.Items.Add("група " + group);
        //    listBox1.Items.Add(course + " курс");
        //}

        int year = 0;
        int month = 0;

        private void numericyear_ValueChanged(object sender, EventArgs e)
        {
            year = Convert.ToInt32(numericyear.Value);

        }
        private void numericmonth_ValueChanged(object sender, EventArgs e)
        {
            month = Convert.ToInt32(numericmonth.Value);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    numericday.Maximum = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    numericday.Maximum = 30;
                    break;

                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        numericday.Maximum = 29;
                    }
                    else
                        numericday.Maximum = 28;
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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

            //year + date
            int day = 0;
            day = Convert.ToInt32(numericday.Value);
            int NEWmonth = 0;
            NEWmonth = Convert.ToInt32(numericmonth.Value);
            int NEWyear = 0;
            NEWyear = Convert.ToInt32(numericyear.Value);


            //gender
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Оберіть стать");
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
            //listBox1.Items.Add(year);
            listBox1.Items.Add(day + "." + NEWmonth + "." + NEWyear);
            listBox1.Items.Add(gender + " стать");
            listBox1.Items.Add("група " + group);
            listBox1.Items.Add(course + " курс");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
        string gender;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = radioButton1.Text;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = radioButton2.Text;

        }
    }
}
