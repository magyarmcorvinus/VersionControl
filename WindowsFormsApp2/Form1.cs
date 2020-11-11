using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
/*            Button gomb = new Button();
            gomb.Text = "Új gomb vagyok";
            gomb.Width = 300;
            gomb.Left = 10;
            gomb.Top = 10;
            Controls.Add(gomb);
            */
            for (int oszlop = 0; oszlop < 10; oszlop++)
            {
                if (oszlop % 2 == 0)
                {
                    Button gomb = new Button();
                    gomb.Text = "Új gomb vagyok";
                    gomb.Width = 100;
                    gomb.Left = oszlop * 100;
                    gomb.Top = 10;
                    Controls.Add(gomb);
                }
            }


        }

        public int Osszead(int op1, int op2)
        {
            return op1 + op2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Osszead(1, 2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            villogoGomb v = new villogoGomb();
            Controls.Add(v);
        }

        private void villogoGomb1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Egyedi négyzet vagyok");
        }
    }
}
