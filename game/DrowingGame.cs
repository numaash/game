using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class DrowingGame : Form
    {
        private List<Point> points = new List<Point>();
        private Form1 frm;
        public DrowingGame(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void DrowingGame_Load(object sender, EventArgs e)
        {

        }

        private void DrowingGame_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
            this.Refresh();
        }

        private void DrowingGame_Paint(object sender, PaintEventArgs e)
        {
            /*SolidBrush brush = new SolidBrush(Color.Aquamarine);
            Rectangle rect = new Rectangle(20, 50, 300, 300);
            SolidBrush brush1 = new SolidBrush(Color.Bisque);
            SolidBrush brush2 = new SolidBrush(Color.Red);
            e.Graphics.FillRectangle(brush, rect);
            e.Graphics.FillEllipse(brush1, rect);
            e.Graphics.FillPie(brush2, rect, -90, 200);*/
            SolidBrush brush3 = new SolidBrush(Color.Yellow);
            Pen pen = new Pen(Color.SaddleBrown, 2.0f);
            if (points.Count > 2)
            {
                e.Graphics.DrawPolygon(pen, points.ToArray());
                e.Graphics.FillPolygon(brush3, points.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Show();
            frm.GameTimeClosed = DateTime.Now;
            this.Close();
        }
    }
}
