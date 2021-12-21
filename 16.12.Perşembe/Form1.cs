using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._12.Perşembe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsayısal_Click(object sender, EventArgs e)
        {
            lstsayısal.Items.Clear();
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i <= 49; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < 6; i++)
            {
                int sayi = list[rnd.Next(0, list.Count)];
                lstsayısal.Items.Add(sayi);
                list.Remove(sayi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                if (listBox1.SelectedItems != null)
                {
                    listBox2.Items.Add(item);
                }
            }

            int sayac = listBox1.SelectedItems.Count;
            for (int i = 0; i < sayac; i++)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }

            //////////////////////

            foreach (var item in listBox2.SelectedItems)
            {
                if (listBox2.SelectedItems != null)
                {
                    listBox1.Items.Add(item);
                }
            }
            int sayac2 = listBox2.SelectedItems.Count;
            for (int i = 0; i < sayac2; i++)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
            button3.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;

            button2.Enabled = true;

            if(listBox1.SelectedItems != null)
                button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba Dünya");
            //MessageBox.Show("Merhaba", "Uyarı");
            //MessageBox.Show("Merhaba","Uyarı",MessageBoxButtons.YesNo);
            //MessageBox.Show("Merhaba","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            
            DialogResult dr= MessageBox.Show("Merhaba", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            MessageBox.Show(dr.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && !(comboBox1.Items.Contains(textBox1.Text.ToUpper())))
            {
                comboBox1.Items.Add(textBox1.Text.ToUpper());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if (radioButton3.Checked ==true)
            //{
            //    MessageBox.Show(radioButton3.Text);
            //}
            //else if (radioButton4.Checked == true)
            //{
            //    MessageBox.Show(radioButton4.Text);
            //}
            //else
            //    MessageBox.Show(radioButton5.Text);

            foreach (RadioButton rd in groupBox1.Controls)
            {
                if (rd.Checked) 
                    MessageBox.Show(rd.Text);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (var cl in checkedListBox1.CheckedItems)
            {
                str += cl + " ";
            }
            MessageBox.Show(str);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"c:\resim\resim.jpg";
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }
    }
}
