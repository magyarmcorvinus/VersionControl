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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<Ember> emberek = new BindingList<Ember>();
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = emberek;
            
            Ember e = new Ember();
            e.Nev = "Lajos";
            e.kor = 100;
            emberek.Add(e);

            emberek.Add(new Ember { Nev = "LAjos", kor = 100 });
            listBox1.DisplayMember = "Nev";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader f = new StreamReader("bela.txt"))
            {
                while (!f.EndOfStream)
                {
                    label1.Text = f.ReadLine();
                    MessageBox.Show("x");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ember emberke = new Ember();
            emberke.Nev = textBox1.Text;
            emberke.kor = 100;
            emberek.Add(emberke);

        }
    }
}
