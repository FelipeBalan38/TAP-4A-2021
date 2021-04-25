using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
            x = 250;
            y = 270;
        }

        private void areaTrabajo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Red,10,100,200,300);
            g.DrawRectangle(Pens.White, 10, 100, 200, 300);
            g.FillRectangle(Brushes.White, 220, 100, 200, 300);
            g.DrawRectangle(Pens.Black, 220, 100, 200, 300);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics s = e.Graphics;
            s.FillRectangle(Brushes.Black, 0, 0, 70, 70);
            s.DrawRectangle(Pens.White, 0, 0, 70, 70);
        }

        private void panel2_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(10, 5, 65, 65);
            Graphics f = e.Graphics;
            f.FillEllipse(Brushes.Green, r);
        }

    }
}
