using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace caddotnet
{
    public partial class cadfrm : Form
    {
        public Graphics g;
        public Font f;
        public Brush b;
        public Pen p;
        public bool ismd = false;
        public int lastx = 0;
        public int lasty = 0;

        public cadfrm()
        {
            InitializeComponent();
        }

        private void cadfrm_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }

        private void cadfrm_MouseMove(object sender, MouseEventArgs e)
        {
            

            if (ismd == true)
            {
               // g.DrawEllipse(p, e.X, e.Y, 2, 2);
                g.DrawLine(p, lastx, lasty, e.X, e.Y);
            }
            lastx = e.X;
            lasty = e.Y;
        }

        private void cadfrm_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void cadfrm_Load(object sender, EventArgs e)
        {

        }

        private void cadfrm_Shown(object sender, EventArgs e)
        {
            g = CreateGraphics();
            f = this.Font;
            b = new SolidBrush(Color.Black);
            p = new Pen(Color.Black);

        }
    }
}
