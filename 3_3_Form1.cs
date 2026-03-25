namespace pract3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount_light = Convert.ToInt32(numericUpDown1.Value);
            int amount_dark = Convert.ToInt32(numericUpDown2.Value);

            double price_light = 72.03,
                price_dark = 81.14,
                summ_light = 0, summ_dark = 0,
                summ=0;


            if (checkBox1.Checked)
            {
                summ_light = amount_light * price_light;
            }if (amount_light > 20)
            {
                summ_light = amount_light * price_light;
                summ_light = summ_light - (summ_light * 0.15);

            }

            if (checkBox2.Checked)
            {
                summ_dark = amount_dark * price_dark;
            }if (amount_dark > 20)
            {
                summ_dark = amount_dark * price_dark;
                summ_dark = summ_dark - (summ_dark * 0.15);
            }

            if(checkBox1.Checked && checkBox2.Checked)
            {
                summ = summ_light + summ_dark;
            }else if (checkBox1.Checked)
            {
                summ = summ_light;
            }else if (checkBox2.Checked)
            {
                summ=summ_dark;
            }


            //if (amount > 20)
            //{
            //    summ = amount * price;
            //    summ = summ - (summ * 0.15);
            //}
            //else
            //    summ = amount * price;

            summ = Math.Round(summ, 2);

            string fullsumm = Convert.ToString(summ);

            MessageBox.Show(fullsumm);
        }

        
    }
}
