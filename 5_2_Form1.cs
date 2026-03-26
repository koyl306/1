namespace pract5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FolderBrowserDialog fbd = new FolderBrowserDialog();

        private void button1_Click(object sender, EventArgs e)
        {

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = fbd.SelectedPath;

            listBox1.Items.Clear();

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }
    }
}
