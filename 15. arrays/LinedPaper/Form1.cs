using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinedPaper {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			for (int i = 0; i <= 7; i += 1) {
				graphics.DrawLine(Pens.LightSkyBlue, 0, i * 20, 300, i * 20); // первая пара чисел - координаты начала отрезка, вторая - координаты конца
			}
		}
	}
}
