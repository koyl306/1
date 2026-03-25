namespace pract3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double price;
        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(numericUpDown1.Value);

            double summ;

            if (amount > 20)
            {
                summ = amount * price;
                summ = summ - (summ * 0.15);
            }
            else
                summ = amount * price;

            summ = Math.Round(summ, 2);

            string fullsumm = Convert.ToString(summ);

            MessageBox.Show(fullsumm);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 72.03;
            pictureBox1.Image = Properties.Resources.Glass_of_Light_Beer_PNG_Clip_Art_Image;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 81.14;
            
            pictureBox1.Image = Properties.Resources.a_glass_of_dark_beer_on_a_black_background_free_png;

        }
    }
}
