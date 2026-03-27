namespace pract5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            listBox1.Items.Add("Latias");
            listBox1.Items.Add("Breloom");
            listBox1.Items.Add("Shinx");
            listBox1.Items.Add("Raichu");
            listBox1.Items.Add("Primarina");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.latias; break;
                case 1:
                    pictureBox1.Image = Properties.Resources.breloom; break;
                case 2:
                    pictureBox1.Image = Properties.Resources.shinx; break;
                case 3:
                    pictureBox1.Image = Properties.Resources.raichu; break;
                case 4:
                    pictureBox1.Image = Properties.Resources.primarina; break;
            }


        }
    }
}
