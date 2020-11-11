using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepkirakosFeladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int sorszam = 0;
            Kever();
            for (int sor = 0; sor < 5; sor++)
            {
                for (int oszlop = 0; oszlop < 5; oszlop++)
                {
                    sorszam++;
                    Kepkocka k = new Kepkocka();
                    k.Top = sor * 76;
                    k.Left = oszlop * 76;
                    //k.Load("Lo_" + sorszam + ".jpg"); 
                    k.Load("Lo_" + tömb[sorszam-1] + ".jpg"); 
                    this.Controls.Add(k);
                }
            }
        }

        int[] tömb = new int[25];

        void Kever()
        {
            int n = 25;
            for (int i = 0; i < n; i++)
            {
                tömb[i] = i + 1;
            }
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int egyik = rnd.Next(n);
                int másik = rnd.Next(n);
                int köztes = tömb[egyik];
                tömb[egyik] = tömb[másik];
                tömb[másik] = köztes;
            }
        }
    }
}
