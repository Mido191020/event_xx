namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, d;
            a=float.Parse(textBox1.Text);
            b=float.Parse(textBox2.Text);
            c=float.Parse(textBox3.Text);
            d = (a + b + c) / 3;
            textBox4.Text = d.ToString();
        }
    }
}