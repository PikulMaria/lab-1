using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    { 
        DateTime today = DateTime.Now;
        DateTime minimum = DateTime.MinValue;
        DateTime maximum = DateTime.MaxValue;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = today.ToString("dddd dd MMMM yyyy");
            textBox2.MaxLength = 8;   
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int Value=0;
            if (textBox2.Text == "")
            {
                MessageBox.Show("введите число");
                return;
            }          
                Value = Convert.ToInt32(textBox2.Text);
                int min = (minimum - today).Days;
                int max = (maximum - today).Days;

                if (Value < min)
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Слишком маленькое значение (минимальное min:" + min + ")");
                }
                else if (Value > max)
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Слишком большое значение (максимальное max:" + max + ")");
                }
                else
                {
                    int a = Int32.Parse(textBox2.Text); 
                    DateTime calculate = today.AddDays(a);   //System.DateTime c 01.01.0001 до 31.12.9999  
                    textBox3.Text = calculate.ToString("dddd dd MMMM yyyy");
                }         
        }
    }
}

