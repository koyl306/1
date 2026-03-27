namespace pract5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Image> img;

        private void Form1_Load(object sender, EventArgs e)
        {
            img = new List<Image>()
            {
                Properties.Resources.latias,
                Properties.Resources.breloom,
                Properties.Resources.shinx,
                Properties.Resources.raichu,
                Properties.Resources.primarina
            };
        }

        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {


            index = (index - 1 + img.Count) % img.Count;
            pictureBox1.Image = img[index];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = (index + 1) % img.Count;
            pictureBox1.Image = img[index];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }
    }
}
