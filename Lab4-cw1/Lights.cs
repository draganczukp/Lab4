using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_cw1
{
    public partial class Lights : Control
    {

        // Properties
        public Color Color1 { get { return pen1.Color; } set { pen1 = new Pen(value); Refresh(); } }
        public Color Color2 { get { return pen2.Color; } set { pen2 = new Pen(value); Refresh(); } }
        public Color Color3 { get { return pen3.Color; } set { pen3 = new Pen(value); Refresh(); } }

        public bool Enabled1 { get => enabled1; set { enabled1 = value; Refresh(); } }
        public bool Enabled2 { get => enabled2; set { enabled2 = value; Refresh(); } }
        public bool Enabled3 { get => enabled3; set { enabled3 = value; Refresh(); } }

        // State
        private bool enabled1, enabled2, enabled3;
        private Pen pen1, pen2, pen3;
        private Rectangle rect1, rect2, rect3;

        // Constants
        private readonly Pen backgroundPen;

        public Lights()
        {
            pen1 = new Pen(Color.Green);
            pen2 = new Pen(Color.Yellow);
            pen3 = new Pen(Color.Red);

            rect1 = new Rectangle(2, 2, Bounds.Width - 4, (Bounds.Height - 4) / 3);
            rect2 = new Rectangle(rect1.X, rect1.Bottom, rect1.Width, rect1.Height);
            rect3 = new Rectangle(rect2.X, rect2.Bottom, rect2.Width, rect2.Height);

            SetAutoSizeMode(AutoSizeMode.GrowAndShrink);

            InitializeComponent();

            backgroundPen = new Pen(Color.FromArgb(128, 51, 51, 51));

            ResizeRedraw = true;

            ControlAdded += Lights_ControlAdded;
            Resize += Lights_Resize;

        }

        private void Lights_ControlAdded(object sender, ControlEventArgs e)
        {
            var ctrl = (Control)sender;
            ctrl.Width = 50;
            ctrl.Height = 160;
        }

        private void Lights_Resize(object sender, EventArgs e)
        {
            var ctrl = (Control)sender;

            ctrl.Height = ctrl.Width * 3;

            rect1 = new Rectangle(2, 2, ctrl.Width - 4, (ctrl.Height - 4) / 3);
            rect2 = new Rectangle(rect1.X, rect1.Bottom, rect1.Width, rect1.Height);
            rect3 = new Rectangle(rect2.X, rect2.Bottom, rect2.Width, rect2.Height);
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;

            g.FillRectangle(backgroundPen.Brush, 0, 0, Size.Width, Size.Height);

            DrawCircle(g, pen1, Enabled1, rect1);
            DrawCircle(g, pen2, Enabled2, rect2);
            DrawCircle(g, pen3, Enabled3, rect3);

            base.OnPaint(pe);
        }

        private void DrawCircle(Graphics g, Pen pen, bool enabled, Rectangle rec)
        {
            if (enabled)
            {
                g.FillEllipse(pen.Brush, rec);
            }
            else
            {
                g.DrawEllipse(pen, rec);
            }
        }
    }
}
