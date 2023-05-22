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
            if(radioButton1.Checked&&radioButton4.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if(radioButton1.Checked&&radioButton5.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if(radioButton1.Checked&&radioButton6.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if(radioButton2.Checked&&radioButton4.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if(radioButton2.Checked&&radioButton5.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if(radioButton2.Checked&&radioButton6.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if(radioButton3.Checked&&radioButton4.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if(radioButton3.Checked&&radioButton5.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if(radioButton3.Checked &&radioButton6.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }
    }
}