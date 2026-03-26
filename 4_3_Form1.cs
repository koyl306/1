namespace pract4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Sorted = true;
        }
    }
}
