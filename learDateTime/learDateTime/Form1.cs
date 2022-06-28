using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime theDate;
            ////theDate = DateTime.Today;
            //theDate = DateTime.UtcNow;
            //MessageBox.Show(theDate.ToString());
            //int theDay = theDate.Month;
            //MessageBox.Show(theDay.ToString());

            DateTime firstDate = new DateTime(2013, 01, 14);
            DateTime secondDate = DateTime.Parse("1 Feb 2013");
            TimeSpan dateDiff;
            
            dateDiff = secondDate.Subtract(firstDate);
            MessageBox.Show("Date diff:" + dateDiff.ToString());

            firstDate = firstDate.AddDays(30);
            MessageBox.Show(firstDate.ToString("D"));
        }
    }
}