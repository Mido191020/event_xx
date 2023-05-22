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

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b) && int.TryParse((string)textBox3.Text, out c))
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = int.Parse(textBox3.Text);
                textBox4.Text = (a * 15).ToString();
                textBox5.Text = (b * 12).ToString();
                textBox6.Text = (c * 9).ToString();
                textBox7.Text = ((a * 15) + (b * 12) + (c * 9)).ToString();
            }
            else
            {
                MessageBox.Show("invalid input");
            }
        }
    }
}