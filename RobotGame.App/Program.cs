using RobotGame;
class Program
{
	static void Main()
	{
		Console.WriteLine("Application starting please enter the coordinats of area:");

		var inputArea = Console.ReadLine();

		List<string> area = inputArea.Split(' ').ToList();//assume not null and all inputs are proper

		var areaX = int.Parse(area.First());
		var areaY = int.Parse(area.Last());

		Surface gameSurface = new Surface(areaX, areaY);

		for (int i = 0; i < 2; i++)
		{
			Console.WriteLine($"Please enter the coordinates of robot number {i + 1}");

			var coordinatesInput = Console.ReadLine();
			var coordinatesOfRobot = coordinatesInput.Split(' '); 

			int x = int.Parse(coordinatesOfRobot.First());
			int y = int.Parse(coordinatesOfRobot[1]);
			Direction firstDirection = Enum.Parse<Direction>(coordinatesOfRobot.Last());

			Console.WriteLine($"Please enter the movements of robot number {i + 1}.");
			var movements = Console.ReadLine();

			Robot robot = new Robot(x, y, firstDirection, gameSurface);
			robot.Move(movements);

			Console.WriteLine(robot.Print());

			Console.ReadKey();
		}
		Console.ReadKey();
	}
}