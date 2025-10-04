using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30._09._2025Gp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked) groupBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) groupBox2.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) groupBox2.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                groupBox3.Enabled = true;
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                groupBox3.Enabled = true;
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                groupBox3.Enabled = true;
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
            }
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tus =MessageBox.Show("İşlemi onaylıyormusunuz?","YBS Pizza",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (tus == DialogResult.Yes) 
            {
                double toplam = 0;

                //boyut türünün hesaplanması

                if (radioButton1.Checked) toplam += 75;
                else if (radioButton2.Checked) toplam += 100;
                else if (radioButton3.Checked) toplam += 150;

                //hamur türünün hesaplanması 
                if (radioButton4.Checked || radioButton6.Checked) toplam += 20;

                //malzemlerin hesaplanması
                if (checkBox1.Checked) toplam += 10;
                if(checkBox2.Checked) toplam += 12.5;
                if (checkBox3.Checked) toplam += 7.5;
                if (checkBox4.Checked) toplam += 14.5;
                if (checkBox5.Checked) toplam += 11.25;
                if (checkBox6.Checked) toplam += 15.75;
                if (checkBox7.Checked) toplam += 12;
                if (checkBox8.Checked) toplam += 21.75;
                if (checkBox9.Checked) toplam += 17.25;
                if (checkBox10.Checked) toplam += 8.9;

                //adet 
                toplam *= Convert.ToInt32(numericUpDown1.Value);

                MessageBox.Show("Toplam sipariş tutarı  = " +  toplam);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            numericUpDown1.Enabled = false;
            button1.Enabled = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false; 
            radioButton3.Checked = false;

            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            
            checkBox1 .Checked = false;
            checkBox2 .Checked = false;
            checkBox3 .Checked = false;
            checkBox4 .Checked = false;
            checkBox5 .Checked = false;
            checkBox6 .Checked = false;
            checkBox7 .Checked = false;
            checkBox8 .Checked = false;
            checkBox9 .Checked = false;
            checkBox10 .Checked = false;

        }
    }
}
