using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLine {
	public partial class Form1 : Form {
		private Graphics graphics;
		private Image img;

		private int carX = 200;
		private int speed = 2;
		public Form1() {
			InitializeComponent();

			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
			img = Image.FromFile("../../car.png");
			KeyDown += Form1_KeyPress;
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.AntiAlias;

			graphics.Clear(Color.FromArgb(0x44444400));
			DrawCar(carX, 200);
		}

		private void DrawCar(int x, int y) {
			graphics.DrawImage(img, x, y);
		}

		private void Form1_KeyPress(object sender, KeyEventArgs e) {
			Console.WriteLine(Keys.Left);
			switch (e.KeyCode) {
				case Keys.A:
				case Keys.Left:
					carX -= speed;
					break;
				case Keys.D:
				case Keys.Right:
					carX += speed;
					break;
			}
			Invalidate();
		}
	}
}
