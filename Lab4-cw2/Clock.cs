using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_cw2
{
    public partial class Clock : Control
    {
        public bool IsDigital { get => digital; set { digital = value; Refresh(); } }


        private bool digital = false;

        private readonly Pen blackPen, hPen, mPen, sPen;

        private string timeString => DateTime.Now.ToString("HH:mm:ss");

        private static readonly double TWO_PI = Math.PI * 2;
        private static readonly double HALF_PI = Math.PI / 2;

        public Clock()
        {
            blackPen = new Pen(Color.Black);

            hPen = new Pen(Color.Black, 3f);
            mPen = new Pen(Color.Black, 2f);
            sPen = new Pen(Color.Black, 1f);

            InitializeComponent();

            Resize += Clock_Resize;

            var timer = new Timer
            {
                Interval = 200
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Clock_Resize(object sender, EventArgs e)
        {
            var ctrl = (Control)sender;
            if (!digital)
            {
                ctrl.Width = ctrl.Height;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            var g = pe.Graphics;

            if (digital)
            {
                DrawDigitalClock(g);
            }
            else
            {
                DrawAnalogClock(g);
            }

            base.OnPaint(pe);
        }

        private void DrawAnalogClock(Graphics g)
        {
            g.DrawEllipse(blackPen, 0, 0, Width - 2, Width - 2);

            double s_len = Width / 2 * 0.9f;
            double m_len = s_len * 0.8f;

            double h_len = m_len * 0.6f;
            DateTime now = DateTime.Now;

            var h = now.Hour;
            h = h >= 12 ? h - 12 : h;

            var m = now.Minute;
            var s = now.Second;

            double h_angle = MapValue(h + (float)m / 60 / 100, 0, 12, 0, TWO_PI);
            double m_angle = MapValue(m + (float)m / 60 / 100, 0, 60, 0, TWO_PI);
            double s_angle = MapValue(s, 0, 60, 0, TWO_PI);

            Point center = new Point(Width / 2, Width / 2);

            DrawLine(g, hPen, center, h_len, h_angle);
            DrawLine(g, mPen, center, m_len, m_angle);
            DrawLine(g, sPen, center, s_len, s_angle);
        }

        private void DrawLine(Graphics g, Pen pen, Point center, double len, double angle)
        {
            angle -= HALF_PI;
            double x = Math.Cos(angle) * len;
            double y = Math.Sin(angle) * len;

            g.DrawLine(pen, center.X, center.Y, center.X + (float)x, center.Y + (float)y);
        }

        private void DrawDigitalClock(Graphics g)
        {

            SizeF size = g.MeasureString(timeString, Font);

            g.DrawRectangle(blackPen, 0, 0, size.Width, size.Height);

            g.DrawString(timeString, Font, blackPen.Brush, 0, 0);
        }

        private double MapValue(double value, double src_low, double src_high, double tgt_low, double tgt_high)
        {
            return src_low + (tgt_high - tgt_low) * ((value - src_low) / (src_high - src_low));
        }
    }
}
