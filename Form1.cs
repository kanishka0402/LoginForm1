namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

           
                if ((this.textBox1.Text == "Ravi") && (this.textBox2.Text == "qwerty"))
            {
                MessageBox.Show("Access Granted");
            }
            
            else 
            {
                MessageBox.Show("Access Not Granted");
            }
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}