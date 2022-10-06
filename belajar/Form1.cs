namespace belajar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int a = 1; a <= 10; a++)
            {
                comboBox1.Items.Add(a * 10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            int selectedIndex = comboBox1.SelectedIndex;
            comboBox1.SelectedItem.ToString();
            int selectedValue = (int)comboBox1.Items[selectedIndex];
            for (int a = 1; a <= selectedValue; a++) 
            {
                if (radioButton1.Checked)
                {
                    if (a % 2 != 0)
                    {
                        textBox1.Text = textBox1.Text + " " + a;
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (a % 2 == 0)
                    {
                        textBox1.Text = textBox1.Text + " " + a;
                    }
                }
                else
                {
                    int faktorial = 0;
                    for (int b = 1; b <= a; b++)
                    {
                        if (a % b == 0)
                        {
                            faktorial++;
                        }
                        if (faktorial > 2)
                        {
                            break;
                        }
                    }
                    if (faktorial == 2)
                    {
                        textBox1.Text = textBox1.Text + " " + a;
                    }
                }
            }
            
        }
    }
}