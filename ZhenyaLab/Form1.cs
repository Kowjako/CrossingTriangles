using Library10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhenyaLab
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<Triangle> t;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            g = panel1.CreateGraphics();
            t = new List<Triangle>(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t.Count < 2)
            {
                t.Add(Functionality.newTriangle(Int32.Parse(x1.Text) * 2, Int32.Parse(y1.Text) * 2, Int32.Parse(x2.Text) * 2, Int32.Parse(y2.Text) * 2, Int32.Parse(x3.Text) * 2, Int32.Parse(y3.Text) * 2));
            }
            else MessageBox.Show("Два треугольника уже созданы !", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (t.Count != 0)
            {
                drawTriangle(e.Graphics);
            }
        } 
        public void drawTriangle(Graphics g)
        {
            Color[] colors = { Color.Red, Color.Blue };
            int i = 0;
            foreach (Triangle t in t)
            {
                Pen myPen = new Pen(colors[i]);
                myPen.Width = 2.0F;
                g.DrawLine(myPen, t.vertex1.x, t.vertex1.y, t.vertex2.x, t.vertex2.y);
                g.DrawLine(myPen, t.vertex1.x, t.vertex1.y, t.vertex3.x, t.vertex3.y);
                g.DrawLine(myPen, t.vertex2.x, t.vertex2.y, t.vertex3.x, t.vertex3.y);
                myPen.Dispose();
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t.Count == 2)
            {
                if (Functionality.comapreTriangles(t[0], t[1]) == 1) MessageBox.Show("Первый больше", "Сравнение площадей", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Второй больше", "Сравнение площадей", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Создайте два треугольника!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t.Count == 2)
            {
                if (Functionality.checkIfCoveredByAnother(t[0],t[1]) == true) MessageBox.Show("Треугольники пересекаются!", "Проверка пересечения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Нет пересечения!", "Проверка пересечения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Создайте два треугольника!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
