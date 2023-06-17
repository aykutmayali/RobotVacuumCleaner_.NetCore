// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace RobotVacuumCleaner;

public class Program
{
    public static void Main()
    {
        int roomWidth, roomHeight;
        Position firstRobotPosition, secondRobotPosition;
        string firstRobotInstructions, secondRobotInstructions;

        // //For Running Test Uncomment
        RobotVacuumCleanerTests tests = new RobotVacuumCleanerTests();
        tests.TestRobotVacuumCleaner();

        // // Parse input
        // Console.WriteLine("Enter Room Size for X Y");
        // string[] roomSize = Console.ReadLine().Split(' ');
        // roomWidth = int.Parse(roomSize[0]);
        // roomHeight = int.Parse(roomSize[1]);

        // Console.WriteLine("Enter first robot initial position for X Y and Orientation");
        // string[] firstRobotData = Console.ReadLine().Split(' ');
        // int firstRobotX = int.Parse(firstRobotData[0].ToString());
        // int firstRobotY = int.Parse(firstRobotData[1].ToString());
        // Orientation firstRobotOrientation = (Orientation)Enum.Parse(typeof(Orientation), firstRobotData[2]);
        // firstRobotPosition = new Position(firstRobotX, firstRobotY, firstRobotOrientation);

        // Console.WriteLine("Enter first robot commands");
        // firstRobotInstructions = Console.ReadLine();

        // Console.WriteLine("Enter second robot initial position for X Y and Orientation");
        // string[] secondRobotData = Console.ReadLine().Split(' ');
        // int secondRobotX = int.Parse(secondRobotData[0].ToString());
        // int secondRobotY = int.Parse(secondRobotData[1].ToString());
        // Orientation secondRobotOrientation = (Orientation)Enum.Parse(typeof(Orientation), secondRobotData[2]);
        // secondRobotPosition = new Position(secondRobotX, secondRobotY, secondRobotOrientation);

        // Console.WriteLine("Enter second robot commands");
        // secondRobotInstructions = Console.ReadLine();

        // // Create RobotVacuumCleaner instance
        // var vacuumCleaner = new RobotVacuumCleaner(firstRobotPosition, firstRobotInstructions, secondRobotPosition, secondRobotInstructions);

        // // Get final positions        
        // Position firstRobotFinalPosition = vacuumCleaner.GetFirstRobotPosition();
        // Position secondRobotFinalPosition = vacuumCleaner.GetSecondRobotPosition();

        // // Output final positions
        // Console.WriteLine("first robot position : ");
        // Console.WriteLine(firstRobotFinalPosition);

        // Console.WriteLine("second robot position : ");
        // Console.WriteLine(secondRobotFinalPosition);

    }
}