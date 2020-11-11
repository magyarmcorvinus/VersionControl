using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int sor = 0; sor < 8; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    Pixel p = new Pixel();
                    p.Top = sor * 30;
                    p.Left = oszlop * 30;
                    p.Width = 30;
                    p.Height = 30;
                    panel1.Controls.Add(p);
                }
            }
        }

        private void ParameterModosul(object sender, EventArgs e)
        {
            byte r = 0;
            byte g = 0;
            byte b = 0;
            try
            {
                r = byte.Parse(textBox1.Text);
                g = byte.Parse(textBox2.Text);
                b = byte.Parse(textBox3.Text);

            }
            catch (Exception)
            {
            }


            Color kivantszin = Color.FromArgb(r, g, b);
            foreach (Pixel item in panel1.Controls)
            {
                item.SelectedColor = kivantszin;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = colorDialog1.Color.R.ToString();
                textBox2.Text = colorDialog1.Color.G.ToString();
                textBox3.Text = colorDialog1.Color.B.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter f = new StreamWriter(saveFileDialog1.FileName);
                f.WriteLine(textBox1.Text);
                f.WriteLine(textBox2.Text);
                f.WriteLine(textBox3.Text);
                f.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = f.ReadLine();
                textBox2.Text = f.ReadLine();
                textBox3.Text = f.ReadLine();
                f.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                while (!f.EndOfStream)
                {
                    string s = f.ReadLine();
                    textBox4.Text = textBox4.Text + s + "\r\n";
                }
                f.Close();
            }

        }
    }
}
