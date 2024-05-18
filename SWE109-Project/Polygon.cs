using System;
using System.Collections.Generic;

public class Polygon
{
	public Point2D Center { get; set; }
	public double Length { get; set; }
	public int NumberOfEdges { get; set; }
	public List<Point2D> Vertices { get; set; }

	// Default constructor
	public Polygon()
	{
		Center = new Point2D();
		Length = 4;
		NumberOfEdges = 5;
		Vertices = new List<Point2D>();
	}

	// Constructor with center and length parameters
	public Polygon(Point2D center, double length, int numberOfEdges)
	{
		Center = center;
		Length = length;
		NumberOfEdges = numberOfEdges;
		Vertices = new List<Point2D>();
	}

	// Method to calculate edge coordinates
	public void CalculateEdgeCoordinates()
	{
		Vertices.Clear();
		double angleStep = 360.0 / NumberOfEdges;
		Random rand = new Random();

		for (int i = 0; i < NumberOfEdges; i++)
		{
			// Convert to radians
			double angle = angleStep * i * (Math.PI / 180); 
			double x = Center.X + Length * Math.Cos(angle);
			double y = Center.Y + Length * Math.Sin(angle);
			Vertices.Add(new Point2D { X = x, Y = y });
		}
	}

	// Method to rotate polygon
	public void RotatePolygon(double angle)
	{
		// Convert to radians
		double angleRad = angle * (Math.PI / 180); 

		for (int i = 0; i < Vertices.Count; i++)
		{
			double x = Vertices[i].X - Center.X;
			double y = Vertices[i].Y - Center.Y;

			Vertices[i].X = Center.X + (x * Math.Cos(angleRad) - y * Math.Sin(angleRad));
			Vertices[i].Y = Center.Y + (x * Math.Sin(angleRad) + y * Math.Cos(angleRad));
		}
	}
}

