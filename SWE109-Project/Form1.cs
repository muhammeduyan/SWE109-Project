using System;
using System.Windows.Forms;

namespace SWE109_Project
{
	public partial class Form1 : Form
	{
		private Polygon polygon;
		private Random rand = new Random();

		public Form1()
		{
			InitializeComponent();
			SetDefaultValues();
		}

		private void SetDefaultValues()
		{
			// Textboxes
			txtCenterX.Text = "0";
			txtCenterY.Text = "0";
			txtLength.Text = "4" ;
			txtEdges.Text = "5";
			txtRotation.Text = "30";

		}

		private void btnDraw_Click_1(object sender, EventArgs e)
		{
			double centerX = double.Parse(txtCenterX.Text);
			double centerY = double.Parse(txtCenterY.Text);
			double length = double.Parse(txtLength.Text);
			int edges = int.Parse(txtEdges.Text);

			polygon = new Polygon(new Point2D { X = centerX, Y = centerY }, length, edges);
			polygon.CalculateEdgeCoordinates();
			DrawPolygon();
			ListVertices();
		}

		private void btnRotate_Click_1(object sender, EventArgs e)
		{
			if (polygon == null)
			{
				MessageBox.Show("No polygon drawn.");
				return;
			}

			double angle = double.Parse(txtRotation.Text);
			polygon.RotatePolygon(angle);
			DrawPolygon();
			ListVertices();
		}

		private void btnRandom_Click_1(object sender, EventArgs e)
		{
			Random rand = new Random();
			txtCenterX.Text = rand.Next(0, 4).ToString();
			txtCenterY.Text = rand.Next(0, 4).ToString();
			txtLength.Text = rand.Next(0, 150).ToString();
			txtEdges.Text = rand.Next(3, 11).ToString();
			txtRotation.Text = rand.Next(0, 360).ToString();
		}

		private void DrawPolygon()
		{
			if (polygon == null) return;

			System.Drawing.Graphics g = pictureBox.CreateGraphics();
			g.Clear(System.Drawing.Color.White);

			System.Drawing.PointF[] points = new System.Drawing.PointF[polygon.Vertices.Count];
			for (int i = 0; i < polygon.Vertices.Count; i++)
			{
				points[i] = new System.Drawing.PointF(
					(float)(polygon.Vertices[i].X + pictureBox.Width / 2),
					(float)(pictureBox.Height / 2 - polygon.Vertices[i].Y));
			}

			g.DrawPolygon(System.Drawing.Pens.Black, points);
		}

		private void ListVertices()
		{
			if (polygon == null) return;

			lstVertices.Items.Clear();
			foreach (var vertex in polygon.Vertices)
			{
				lstVertices.Items.Add($"(X: {vertex.X}, Y: {vertex.Y})");
			}
		}

		
	}
}

