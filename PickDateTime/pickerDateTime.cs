using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickDateTime
{
    public partial class pickerDateTime : UserControl
    {
        public pickerDateTime()
        {
            InitializeComponent();
        }
        public int MM = 0;

        public int DD = 0;
        public int D1 = 0;
        public int D2 = 0;

        public int YYYY = 0;

        public int Y1 = 0;
        public int Y2 = 0;
        public int Y3 = 0;
        public int Y4 = 0;


        public int hh = 0;
        public int h1 = 0;
        public int h2 = 0;

        public int mm = 0;
        public int m1 = 0;
        public int m2 = 0;
        
        public int ss = 0;
        public int s1 = 0;
        public int s2 = 0;
        
        public int ms = 0;
        public int ms1 = 0;
        public int ms2 = 0;

        public string apm = "   ";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MM = Convert.ToInt16(comboBox1.Text);
            textBox1.Text = MM.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            D1 = Convert.ToInt16(comboBox2.Text);
            DD = D1 * 10;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            D2 = Convert.ToInt16(comboBox3.Text);
            DD = DD + D2;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y1 = Convert.ToInt16(comboBox4.Text);
            YYYY = Y1 * 1000;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y2 = Convert.ToInt16(comboBox5.Text);
            YYYY = YYYY + (Y2 * 100);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y3 = Convert.ToInt16(comboBox6.Text);
            YYYY = YYYY + (Y3 * 10);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Y4 = Convert.ToInt16(comboBox7.Text);
            YYYY = YYYY + (Y4);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            h1 = Convert.ToInt16(comboBox8.Text);
            hh = h1 * 10;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            h2 = Convert.ToInt16(comboBox9.Text);
            hh = hh + h2;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            m1 = Convert.ToInt16(comboBox11.Text);
            mm = m1 * 10;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            m2 = Convert.ToInt16(comboBox10.Text);
            mm = mm + m2;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            s1 = Convert.ToInt16(comboBox13.Text);
            ss = s1 * 10;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = Convert.ToInt16(comboBox12.Text);
            ss = ss + s2;
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            ms1 = Convert.ToInt16(comboBox16.Text);
            ms = ms1 * 10;
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            ms2 = Convert.ToInt16(comboBox15.Text);
            ms = ms + ms2;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            apm = comboBox14.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           if(MM<10){ textBox1.Text += "0"; }
            else if (MM == 0) { textBox1.Text += "00"; }
            textBox1.Text += MM.ToString() + "/";
           if (DD < 10) { textBox1.Text += "0"; }
            textBox1.Text += DD.ToString();
            textBox1.Text += "/";
           if (YYYY == 0) { textBox1.Text += "0000"; }
            textBox1.Text += YYYY.ToString();
            textBox1.Text += " ";
           if (hh < 10) { textBox1.Text += "0"; }
            else if (hh == 0) { textBox1.Text += "00"; }
            textBox1.Text += hh.ToString();
            textBox1.Text += ":";
           if (mm < 10) { textBox1.Text += "0"; }
            textBox1.Text += mm.ToString();
            textBox1.Text += ":";
           if (ss < 10) { textBox1.Text += "0"; }
            textBox1.Text += ss.ToString();
            textBox1.Text += ":";
           if (ms < 10) { textBox1.Text += "0"; }
            textBox1.Text +=   ms.ToString();
            if (apm == "   ") { textBox1.Text += "AM"; }
            textBox1.Text += " " + apm;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
