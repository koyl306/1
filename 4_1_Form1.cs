using System.Net.Http.Headers;

namespace pract4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkSalary selvaleu = (WorkSalary)listBox1.SelectedItem;
            double multik = Convert.ToDouble(selvaleu.Multiplier);

            WorkSalary salary = (WorkSalary)comboBox1.SelectedItem;
            double salval = Convert.ToDouble(salary.Multiplier);

            double exp = 0;
            exp = Convert.ToDouble(numericUpDown1.Value);
            exp = exp * 0.1;

            double prognosedsal = 0;
            prognosedsal = salval * multik +(salval*multik* exp);

            textBox1.Text= prognosedsal.ToString();
        }


        public class WorkSalary
        {
            public string Text { get; set; }
            public double Multiplier { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var object1 = new WorkSalary { Text = "Системний адміністратор", Multiplier = 1.5 };
            listBox1.Items.Add(object1);
            var object2 = new WorkSalary { Text = "Веб-програміст", Multiplier = 1.3 };
            listBox1.Items.Add(object2);
            var object3 = new WorkSalary { Text = "Веб-дизайнер", Multiplier = 1.0 };
            listBox1.Items.Add(object3);
            var object4 = new WorkSalary { Text = "Модератор сайтів", Multiplier = 2.0 };
            listBox1.Items.Add(object4);

            listBox1.Sorted = true;


            var object5 = new WorkSalary { Text = "Від 5000 грн", Multiplier = 5000 };
            comboBox1.Items.Add(object5);
            var object6 = new WorkSalary { Text = "Від 10000 грн", Multiplier = 10000 };
            comboBox1.Items.Add(object6);
            var object7 = new WorkSalary { Text = "Від 15000 грн", Multiplier = 15000 };
            comboBox1.Items.Add(object7);
            var object8 = new WorkSalary { Text = "Від 20000 грн", Multiplier = 20000 };
            comboBox1.Items.Add(object8);
            var object9 = new WorkSalary { Text = "Від 25000 грн", Multiplier = 25000 };
            comboBox1.Items.Add(object9);
            var object10 = new WorkSalary { Text = "Від 30000 грн", Multiplier = 30000 };
            comboBox1.Items.Add(object10);
        }
    }
}
