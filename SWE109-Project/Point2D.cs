using System;

public class Point2D
{
	public double X { get; set; }
	public double Y { get; set; }

	// Default constructor
	public Point2D()
	{
		X = 0;
		Y = 0;
	}

	// Constructor with random initial coordinates
	public Point2D(Random rand)
	{
		X = rand.NextDouble() * 3;
		Y = rand.NextDouble() * 3;
	}

	// Method to print coordinates
	public void PrintCoordinates()
	{
		Console.WriteLine($"Cartesian Coordinates: (X: {X}, Y: {Y})");
	}

	// Method to calculate polar coordinates
	public (double r, double theta) CalculatePolarCoordinates()
	{
		double r = Math.Sqrt(X * X + Y * Y);
		double theta = Math.Atan2(Y, X) * (180 / Math.PI); // Convert radians to degrees
		return (r, theta);
	}

	// Method to print polar coordinates
	public void PrintPolarCoordinates()
	{
		var (r, theta) = CalculatePolarCoordinates();
		Console.WriteLine($"Polar Coordinates: (r: {r}, θ: {theta}°)");
	}
}

