using System;
using System.IO;
namespace RobotVacuumCleaner;

public class RobotVacuumCleanerTests
{
    public void TestRobotVacuumCleaner()
    {
        int roomWidth, roomHeight;
        roomWidth = 5;
        roomHeight = 5;
        Position firstRobotPosition = new Position(1, 2, Orientation.N);
        string firstRobotInstructions = "LMLMLMLMM";
        Position secondRobotPosition = new Position(3, 3, Orientation.E);
        string secondRobotInstructions = "MMRMMRMRRM";

        RobotVacuumCleaner vacuumCleaner = new RobotVacuumCleaner(firstRobotPosition, firstRobotInstructions, secondRobotPosition, secondRobotInstructions, roomWidth, roomHeight);

        Position firstRobotFinalPosition = vacuumCleaner.GetFirstRobotPosition();
        Position secondRobotFinalPosition = vacuumCleaner.GetSecondRobotPosition();

        Console.WriteLine("first robot position : ");
        Console.WriteLine(firstRobotFinalPosition);  // Output: 1 3 N
        Console.WriteLine("second robot position : ");
        Console.WriteLine(secondRobotFinalPosition); // Output: 5 1 E
    }
}