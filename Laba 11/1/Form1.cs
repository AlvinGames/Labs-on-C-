using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2;
            if(double.TryParse(textBox1.Text, out n1))
            {
                if(double.TryParse(textBox2.Text, out n2))
                {
                    textBox3.Text = Convert.ToString(sum(n1, n2));
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
            }
        }

        public double sum(double a,double b)
        {
            return a + b;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                listBox1.Items.Add(textBox4.Text);
                textBox4.Clear();
                textBox4.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>();
                string name = openFileDialog1.FileName;
                foreach (var item in File.ReadAllLines(name, Encoding.UTF8))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ActiveForm.Font = fontDialog1.Font;
            menuStrip1.Font = fontDialog1.Font;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Application.Exit();
            TopMost = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                gr.DrawEllipse(new Pen(Color.Red, 5), new Rectangle(e.X - 12, e.Y - 12, 25, 25));
            }
            else if (e.Button == MouseButtons.Right)
            {
                gr.DrawRectangle(new Pen(Color.Green, 5), new Rectangle(e.X - 12, e.Y - 12, 25, 25));
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Controls.Add(btn);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "Thank you";
            Controls.Remove(btn);
        }
    }
}
