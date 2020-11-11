using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class villogoGomb: Button
    {
        public villogoGomb()
        {
            this.Width = 30;
            this.Height = 30;
            this.MouseClick += VillogoGomb_MouseClick;
        }

        private void VillogoGomb_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Négyzet vagyok");
        }
    }
}
