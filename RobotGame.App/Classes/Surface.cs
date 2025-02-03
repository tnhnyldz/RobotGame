namespace RobotGame
{
	internal class Surface
	{
		public int BorderX { get; set; }
		public int BorderY { get; set; }

		public Surface(int borderX, int borderY)
		{
			BorderX = borderX;
			BorderY = borderY;
		}

		public int SetX(int x)
		{
			if (x < 0)
				return 0;
			else if (x > BorderX)
				return BorderX;
			else
				return x;
		}

		public int SetY(int y)
		{
			if (y < 0)
				return 0;
			else if (y > BorderY)
				return BorderY;
			else
				return y;
		}

	}
}
