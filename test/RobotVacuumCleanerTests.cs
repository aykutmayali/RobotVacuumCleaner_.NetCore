using System;
using System.IO;
namespace RobotVacuumCleaner;

public class RobotVacuumCleanerTests
{
    public void TestRobotVacuumCleaner()
    {
        Position firstRobotPosition = new Position(1, 2, Orientation.N);
        string firstRobotInstructions = "LMLMLMLMM";
        Position secondRobotPosition = new Position(3, 3, Orientation.E);
        string secondRobotInstructions = "MMRMMRMRRM";

        RobotVacuumCleaner vacuumCleaner = new RobotVacuumCleaner(firstRobotPosition, firstRobotInstructions, secondRobotPosition, secondRobotInstructions);

        Position firstRobotFinalPosition = vacuumCleaner.GetFirstRobotPosition();
        Position secondRobotFinalPosition = vacuumCleaner.GetSecondRobotPosition();

        Console.WriteLine(firstRobotFinalPosition);  // Output: 1 3 N
        Console.WriteLine(secondRobotFinalPosition); // Output: 5 1 E
    }
}