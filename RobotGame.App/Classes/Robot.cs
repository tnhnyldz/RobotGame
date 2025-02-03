namespace RobotGame
{
	internal class Robot
	{
		private int X { get; set; }
		private int Y { get; set; }

		private Direction Face { get; set; }

		private Surface _surface;

		public Robot(int x, int y, Direction direction, Surface surface)
		{
			_surface = surface;
			X = _surface.SetX(x);
			Y = _surface.SetX(y);
			Face = direction;
		}

		public void Move(string movements)
		{
			foreach (var movement in movements) 
			{
				switch (movement)
				{
					case 'L':
						TurnLeft();
						break;
					case 'R':
						TurnRight();
						break;
					case 'M':
						MoveForward();
						break;
				}
			}
		}
		public void TurnLeft() 
		{
			switch (Face)
			{
				case Direction.N:
					Face = Direction.W;
					break;
				case Direction.W:
					Face = Direction.S;
					break;
				case Direction.S:
					Face = Direction.E;
					break;
				case Direction.E:
					Face = Direction.N;
					break;
				default:
					break;
			}
		}
		private void TurnRight()
		{
			switch (Face)
			{
				case Direction.N:
					Face = Direction.E;
					break;
				case Direction.E:
					Face = Direction.S;
					break;
				case Direction.S:
					Face = Direction.W;
					break;
				case Direction.W:
					Face = Direction.N;
					break;
				default:
					break;
			}
		}
		private void MoveForward()
		{
			int newX = X, newY = Y;

			switch (Face)
			{
				case Direction.N:
					newY++;
					break;
				case Direction.S:
					newY--;
					break;
				case Direction.E:
					newX++;
					break;
				case Direction.W:
					newX--;
					break;
			}
			X = _surface.SetX(newX);
			Y = _surface.SetY(newY);
		}

		public string Print()
		{
			return $"{X} {Y} {Face}";
		}
	}
}
