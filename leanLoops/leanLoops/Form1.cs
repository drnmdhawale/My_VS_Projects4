using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leanLoops
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
            
            int loopStart;
            int loopEnd;
            int answer = 0;
            int multiplyBy;

            int outputValue1 = 0;
            int outputValue2 = 0;
            int outputValue3 = 0;

            bool isNumber1 = false;
            bool isNumber2 = false;
            bool isNumber3 = false;

            isNumber1 = int.TryParse(textBox1.Text, out outputValue1);
            isNumber2 = int.TryParse(textBox2.Text, out outputValue2);
            isNumber3 = int.TryParse(textBox3.Text, out outputValue3);

            if (!isNumber1 || !isNumber2 || !isNumber3)
            {
                MessageBox.Show("Type numbers in the text boxes");
            }
            else
            {
                loopStart = int.Parse(textBox1.Text);
                loopEnd = int.Parse(textBox2.Text);
                multiplyBy = int.Parse(textBox3.Text); 
                
                for (int i = loopStart; i <= loopEnd; i++)
                {
                    answer = multiplyBy * i;

                    listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());
                }
            }


        }
    }
}
