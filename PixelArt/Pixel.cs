using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
    class Pixel: Label
    {
        bool Selected = false;
        Color DefaultColor = Color.DarkGray;
        public Color SelectedColor = Color.Black;

        public Pixel()
        {
            this.BackColor = DefaultColor;
            this.MouseEnter += Pixel_MouseEnter;
            this.Click += Pixel_Click;
            this.MouseLeave += Pixel_MouseLeave;
        }

        private void Pixel_MouseLeave(object sender, EventArgs e)
        {
            if (!Selected)
            {
                this.BackColor = DefaultColor;
            }
        }

        private void Pixel_Click(object sender, EventArgs e)
        {
            Selected = !Selected;
            if (Selected)
                this.BackColor = SelectedColor;
            else
                this.BackColor = DefaultColor;
        }

        private void Pixel_MouseEnter(object sender, EventArgs e)
        {
            if (!Selected)
            {
                this.BackColor = SelectedColor;
            }
        }
    }
}
