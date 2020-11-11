using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepkirakosFeladat
{
    class Kepkocka: PictureBox
    {
        int ox;
        int oy;
        bool mozoge = false;

        public Kepkocka()
        {

            this.BackColor = Color.Fuchsia;
            this.Width = 76;
            this.Height = 76;

            this.MouseMove += Kepkocka_MouseMove;
            this.MouseUp += Kepkocka_MouseUp;
            this.MouseDown += Kepkocka_MouseDown;
        }

        private void Kepkocka_MouseDown(object sender, MouseEventArgs e)
        {
            ox = e.X;
            oy = e.Y;
            mozoge = true;
        }

        private void Kepkocka_MouseUp(object sender, MouseEventArgs e)
        {
            mozoge = false;
        }

        private void Kepkocka_MouseMove(object sender, MouseEventArgs e)
        {
            if (mozoge)
            {
                this.Left += (e.X - ox);
                this.Top += (e.Y - oy);
            }
        }
    }
}
