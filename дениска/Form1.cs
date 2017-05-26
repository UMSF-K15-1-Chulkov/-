using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дениска
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bild = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bild);
            Random r = new Random();
            SolidBrush sb = new SolidBrush(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            Pen p1 = new Pen(sb, 5);
            Pen p2 = new Pen(Color.Black, 1);
            Point[] p = new Point[4];
            p[0].X = 80; p[0].Y = 10;
            p[1].X = 120; p[1].Y = 45;
            p[2].X = 80; p[2].Y = 80;
            p[3].X = 40; p[3].Y = 45;
            gr.FillPolygon(Brushes.Purple, p);
            gr.FillEllipse(Brushes.LightPink, 55, 38, 54, 54);
            Point[] d = new Point[3];
            d[0].X = 58; d[0].Y = 78;
            d[1].X = 107; d[1].Y = 78;
            d[2].X = 81; d[2].Y = 112;
            gr.FillPolygon(Brushes.LightSkyBlue, d);
            Point[] f = new Point[3];
            f[0].X = 58; f[0].Y = 78;
            f[1].X = 107; f[1].Y = 78;
            f[2].X = 81; f[2].Y = 112;
            gr.DrawPolygon(p2, f);
            gr.FillEllipse(Brushes.White, 66, 52, 16, 16);
            gr.FillEllipse(Brushes.White, 82, 52, 16, 16);
            gr.FillEllipse(Brushes.Black, 66, 52, 10, 10);
            gr.FillEllipse(Brushes.Black, 82, 52, 10, 10);
            Point[] w = new Point[3];
            w[0].X = 83; w[0].Y = 66;
            w[1].X = 92; w[1].Y = 85;
            w[2].X = 74; w[2].Y = 85;
            gr.FillPolygon(Brushes.LightSkyBlue, w);
            Point[] k = new Point[3];
            k[0].X = 83; k[0].Y = 66;
            k[1].X = 92; k[1].Y = 85;
            k[2].X = 74; k[2].Y = 85;
            gr.DrawPolygon(p2, k);
            gr.FillRectangle(Brushes.Red, 80, 67, 7, 7);
            Point[] q = new Point[3];
            q[0].X = 40; q[0].Y = 47;
            q[1].X = 50; q[1].Y = 62;
            q[2].X = 30; q[2].Y = 62;
            gr.FillPolygon(Brushes.Purple, q);
            pictureBox1.Image = bild;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
